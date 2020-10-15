import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './role-routing.module';
import { RoleComponent } from './role.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AuthService } from '../../service/auth/authservice.service';
import { AddRoleComponent } from './addrole/addrole.component';
import { RoleService } from '../../api-service/role/roleservice.service';


@NgModule({
  declarations: [RoleComponent, AddRoleComponent],

  imports: [
    CommonModule,
    UserRoutingModule,
    HttpClientModule,
    FormsModule
  ],providers:[RoleService]
})
export class RoleModule { }
