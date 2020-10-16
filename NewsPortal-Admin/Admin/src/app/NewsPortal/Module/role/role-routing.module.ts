import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddRoleComponent } from '../role/addrole/addrole.component';

import { RoleComponent } from './role.component';

const routes: Routes = [
  { path: '', component: RoleComponent },
  { path: 'add', component: AddRoleComponent },
  { path: 'edit/:id', component: AddRoleComponent },


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }
