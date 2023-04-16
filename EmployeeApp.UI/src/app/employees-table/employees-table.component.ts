import { Component, ViewChild, Input, SimpleChange } from '@angular/core';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Employee } from '../_models/employee';
import { EmployeeService } from '../_services/employee.service';

@Component({
  selector: 'app-employees-table',
  templateUrl: './employees-table.component.html',
  styleUrls: ['./employees-table.component.scss']
})
export class EmployeesTableComponent {
  displayedColumns: string[] = ['name', 'hireDate'];
  dataSource!: MatTableDataSource<Employee>;

  constructor(private employeeService: EmployeeService) {
    }

  @ViewChild(MatSort) sort!: MatSort;

  @Input() searchInvoked!: Boolean;

  ngOnChanges(changes: SimpleChange): void {
    this.loadEmployees();
    this.searchInvoked = false;
  }

  loadEmployees() {
    this.employeeService.getEmployees().subscribe({
      next: (result: Employee[]) => {
      this.dataSource = new MatTableDataSource(result);
      this.dataSource.sort = this.sort;
      },
      error: err => {
        console.log(err);
      }
    });
  }
}
