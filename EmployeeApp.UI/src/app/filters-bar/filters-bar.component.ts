import { Component } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { map, startWith } from 'rxjs/operators';
import { EmployeeService } from '../_services/employee.service';
import { Moment } from 'moment';
import { Employee } from '../_models/employee';

@Component({
  selector: 'app-filters-bar',
  templateUrl: './filters-bar.component.html',
  styleUrls: ['./filters-bar.component.scss']
})
export class FiltersBarComponent {
  form = new FormGroup({
    selectedName: new FormControl<string | null>(null),
    selectedManagerId: new FormControl<number | null>(null),
    startDate: new FormControl<Moment | null>(null),
    endDate: new FormControl<Moment | null>(null)
  });

  employeesNames!: string[];
  filteredEmployeesNames!: Observable<string[]>;

  managers!: Employee[];

  constructor(private employeeService: EmployeeService) {
  }
  
  ngOnInit() {
    this.loadEmployeesNames();
    this.loadManagers();
  }

  private loadManagers() {
    this.employeeService.getManagers().subscribe({
      next: (result: Employee[]) => {
      this.managers = result;
      },
      error: err => {
        console.log(err);
      }
    });
  }

  private loadEmployeesNames() {
    this.employeeService.getEmployeesNames().subscribe({
      next: (result: string[]) => {
      this.employeesNames = result;
      this.fillFilteredEmployeesNames();
      },
      error: err => {
        console.log(err);
      }
    });
  }

  private _filter(value: string): string[] {
    const filterValue = value.toLowerCase();
    return this.employeesNames.filter(employeesName => employeesName.toLowerCase().includes(filterValue));
  }

  fillFilteredEmployeesNames() {
    this.filteredEmployeesNames = this.form.controls.selectedName.valueChanges.pipe(
      startWith(''),
      map(value => this._filter(value || '')),
    );
  }

  onFilter() {
    console.log(this.form.controls.selectedName.value);
    console.log(this.form.controls.startDate.value?.toISOString());
    console.log(this.form.controls.endDate.value?.toISOString());
    console.log(this.form.controls.selectedManagerId.value);
  }
}
