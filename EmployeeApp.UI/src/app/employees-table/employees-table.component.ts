import { Component } from '@angular/core';
import { Employee } from '../_models/employee';

const EMPLOYEES: Employee[] = [
  { id: 1, name: 'Manager One', hireDate: '04/04/2023' },
  { id: 2, name: 'Regular Employee One', hireDate: '05/04/2023' },
  { id: 3, name: 'Regular Employee Two', hireDate: '06/04/2023' }
];

@Component({
  selector: 'app-employees-table',
  templateUrl: './employees-table.component.html',
  styleUrls: ['./employees-table.component.scss']
})
export class EmployeesTableComponent {
  employees = EMPLOYEES;
}
