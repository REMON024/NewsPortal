import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../../../Model/Auth/registration';
import { AuthService } from '../../../service/auth/authservice.service';

@Component({
  selector: 'app-register',
  templateUrl: 'register.component.html'
})
export class RegisterComponent {
  public usermodel:User=new User();
  constructor(private authservice:AuthService,private _Route: Router) { }

  SaveUser(){
    this.authservice.AddUser(this.usermodel).subscribe(res=>{
      console.log(res);
      this._Route.navigate(['auth/login']);

    })
  }
}
