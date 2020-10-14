import { Component, OnInit } from '@angular/core';
import { User } from '../../../Model/Auth/regitrstion';
import { AuthService } from '../../../Service/auth/authservice.service';



@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {
public usermodel:User=new User();
  constructor(private authservice:AuthService) { }

  ngOnInit(): void {
  }


  SaveUser(){
    this.authservice.AddUser(this.usermodel).subscribe(res=>{
      console.log(res);
    })
  }

}
