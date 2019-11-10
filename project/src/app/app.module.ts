import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import { EmployeeComponent } from './employee/employee.component';
import { CompanyModule } from './company/company.module';
import { MyserviceService } from './myservice.service';

import { AutoComponent } from './auto/auto.component';
import { AngularComponent } from './angular/angular.component';
@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    AutoComponent,
    AngularComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSliderModule,
    CompanyModule,
    
  ],
  providers: [MyserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { 

constructor()
{
  console.log("hi , this is module");
}
}