import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddEmployeeComponent } from './components/employees/add-employee/add-employee.component';
import { EmployeesListComponent } from './components/employees/employees-list/employees-list.component';
import { EditEmployeeComponent } from './components/employees/edit-employee/edit-employee.component';

const routes: Routes = [
  
  //Add Home page route
    {
      path: '',
      component: EmployeesListComponent

    },

    //Employee List page route
    {
      path: 'employees',
      component: EmployeesListComponent
  
    },

      //Add Employee page route
      {
        path: 'employees/add',
        component: AddEmployeeComponent
    
      },

      
      //Edit Employee page route
      {
        path: 'employees/edit/:id',
        component: EditEmployeeComponent
    
      }
  


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
