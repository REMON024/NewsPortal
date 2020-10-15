import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthRoutingModule } from './auth-routing.module';
import { AuthComponent } from './auth.component';
import { RegistrationComponent } from './registration/registration.component';
import { AuthService } from 'src/app/Service/auth/authservice.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { LoginComponent } from './login/login.component';
import { HTTPInterceptorProviders } from 'src/app/Service/interceptor/interceptor';


@NgModule({
  declarations: [AuthComponent,RegistrationComponent,LoginComponent],
  imports: [
    CommonModule,
    AuthRoutingModule,
    HttpClientModule,
    FormsModule
  ],providers:[AuthService,HTTPInterceptorProviders]
})
export class AuthModule { }
