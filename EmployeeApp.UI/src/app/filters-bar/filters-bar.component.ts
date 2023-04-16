import { Component, EventEmitter, Output } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { map, startWith } from 'rxjs/operators';
import { EmployeeService } from '../_services/employee.service';
import { Employee } from '../_models/employee';
import { FiltersService } from '../_services/filters.service';

@Component({
  selector: 'app-filters-bar',
  templateUrl: './filters-bar.component.html',
  styleUrls: ['./filters-bar.component.scss']
})
export class FiltersBarComponent {
  form = new FormGroup({
    selectedName: new FormControl(),
    selectedManagerId: new FormControl(),
    fromDate: new FormControl(),
    toDate: new FormControl()
  });

  employeesNames!: string[];
  filteredEmployeesNames!: Observable<string[]>;

  managers!: Employee[];

  @Output() onSearch = new EventEmitter<Boolean>();

  constructor(
    private employeeService: EmployeeService,
    private filtersService: FiltersService
    ) { }
  
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
    this.filtersService.setFilters(
      this.form.controls.fromDate.value,
      this.form.controls.toDate.value,
      this.form.controls.selectedName.value,
      this.form.controls.selectedManagerId.value);
    
    let performSearch = new Boolean(true);
    this.onSearch.emit(performSearch);
  }
}
