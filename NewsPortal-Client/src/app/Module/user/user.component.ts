import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/Service/auth/authservice.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
public lstuser:any;
  constructor(private authservice:AuthService) { }

  ngOnInit(): void {
    this.GetAllUser();

  }

  GetAllUser(){
    this.authservice.GetAllUser().subscribe(res=>{
      console.log(res);
      this.lstuser=res;
    })
  }

}
