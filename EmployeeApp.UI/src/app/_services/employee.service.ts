import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Employee } from '../_models/employee';
import { FiltersService } from './filters.service';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private apiUrl = "https://localhost:7007/api/Employees/";

  constructor(
    private http: HttpClient,
    private filtersService: FiltersService
  ) { }

  getEmployees(): Observable<Employee[]> {
    let params = this.filtersService.getParams();
    
    return this.http.get<Employee[]>(this.apiUrl + 'GetEmployees', {params});
  }

  getManagers(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.apiUrl + 'GetManagers');
  }

  getEmployeesNames(): Observable<string[]> {
    return this.http.get<string[]>(this.apiUrl + 'GetEmployeesNames');
  }
}
