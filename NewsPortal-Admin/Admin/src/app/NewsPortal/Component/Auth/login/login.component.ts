import { Component } from '@angular/core';
import { Login } from '../../../Model/Auth/login';
import { AuthService } from '../../../service/auth/authservice.service';

@Component({
  selector: 'app-login',
  templateUrl: 'login.component.html'
})
export class LoginComponent { 
  public login:Login=new Login();

  constructor(private authservice:AuthService){

  }

  onSubmit() 
  {
      this.authservice.LoginUser(this.login).subscribe(res=>{
        
      });
    }
}
