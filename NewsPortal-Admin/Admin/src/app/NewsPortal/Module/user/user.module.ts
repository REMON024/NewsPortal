import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './user-routing.module';
import { UserComponent } from './user.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AuthService } from '../../service/auth/authservice.service';
import { AdduserComponent } from './adduser/adduser.component';


@NgModule({
  declarations: [UserComponent, AdduserComponent],

  imports: [
    CommonModule,
    UserRoutingModule,
    HttpClientModule,
    FormsModule
  ],providers:[AuthService]
})
export class UserModule { }
