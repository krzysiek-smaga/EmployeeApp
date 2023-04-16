import { AppRoutingModule } from './app-routing.module';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { EmployeesPageComponent } from './employees-page/employees-page.component';
import { EmployeesTableComponent } from './employees-table/employees-table.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './header/header.component';
import { FiltersBarComponent } from './filters-bar/filters-bar.component';

import { MaterialUiSharedModule } from './_modules/material-ui-shared.module';
import { NotFoundPageComponent } from './not-found-page/not-found-page.component';

import { MAT_DATE_LOCALE } from '@angular/material/core';

@NgModule({
  declarations: [
    AppComponent,
    EmployeesPageComponent,
    EmployeesTableComponent,
    HeaderComponent,
    FiltersBarComponent,
    NotFoundPageComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserModule,
    NgbModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MaterialUiSharedModule
  ],
  providers: [
    {provide: MAT_DATE_LOCALE, useValue: 'pl'}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
