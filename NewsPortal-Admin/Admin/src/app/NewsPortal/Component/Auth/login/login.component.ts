import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Login } from '../../../Model/Auth/login';
import { AuthService } from '../../../service/auth/authservice.service';

@Component({
  selector: 'app-login',
  templateUrl: 'login.component.html'
})
export class LoginComponent { 

  public login:Login=new Login();

  constructor(private authservice:AuthService,private _Route: Router){
  }

  onSubmit() 
  {
      this.authservice.LoginUser(this.login).subscribe(res=>{
        console.log("login",res)
      this._Route.navigate(['dashboard']);
        
      });
    }
}
