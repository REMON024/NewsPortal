import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../../../Model/Auth/regitrstion';
import { AuthService } from '../../../Service/auth/authservice.service';



@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {
public usermodel:User=new User();
  constructor(private authservice:AuthService,private _Route: Router) { }

  ngOnInit(): void {
  }


  SaveUser(){
    this.authservice.AddUser(this.usermodel).subscribe(res=>{
      console.log(res);
      this._Route.navigate(['auth/login']);

    })
  }

}
