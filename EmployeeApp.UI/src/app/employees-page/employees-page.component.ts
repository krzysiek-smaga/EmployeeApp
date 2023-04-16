import { Component } from '@angular/core';

@Component({
  selector: 'app-employees-page',
  templateUrl: './employees-page.component.html',
  styleUrls: ['./employees-page.component.scss']
})
export class EmployeesPageComponent {
  searchInvoked!: Boolean;

  invokeSearch($event: Boolean) {
    this.searchInvoked = $event;
  }
}
