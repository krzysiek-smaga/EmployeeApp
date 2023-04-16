import { Injectable } from '@angular/core';
import { Filters } from '../_models/filters';
import { Moment } from 'moment';
import { HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FiltersService {
  private filters: Filters = new Filters();

  setFilters(fromDate: Moment, toDate: Moment, name: string, managerId: number) {
    if(!!fromDate) this.filters.fromDate = fromDate.toISOString();
    else this.filters.fromDate = '';

    if(!!toDate) this.filters.toDate = toDate.toISOString();
    else this.filters.toDate = '';

    if(!!name) this.filters.name = name;
    else this.filters.name = '';

    if(!!managerId) this.filters.managerId = managerId.toString();
    else this.filters.managerId = '';
  }

  getParams(): HttpParams {
    let params = new HttpParams();

    if (!!this.filters) {
      if(!!this.filters.fromDate) params = params.append('fromDate', this.filters.fromDate);
      if(!!this.filters.toDate) params = params.append('toDate', this.filters.toDate);
      if(!!this.filters.name) params = params.append('name', this.filters.name);
      if(!!this.filters.managerId) params = params.append('managerId', this.filters.managerId); 
    }

    return params;
  }
}
