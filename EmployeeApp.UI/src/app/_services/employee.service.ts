import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Employee } from '../_models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private apiUrl = "https://localhost:7007/api/Employees/";

  constructor(
    private http: HttpClient
  ) { }

  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.apiUrl + 'GetEmployees');
  }

  getManagers(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.apiUrl + 'GetManagers');
  }

  getEmployeesNames(): Observable<string[]> {
    return this.http.get<string[]>(this.apiUrl + 'GetEmployeesNames');
  }
}
