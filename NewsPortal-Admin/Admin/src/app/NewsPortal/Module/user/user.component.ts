import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../service/auth/authservice.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
public lstuser:[];
  constructor(private authservice:AuthService) { }

  ngOnInit(): void {
    this.GetAllUser();

  }

  GetAllUser(){
    this.authservice.GetAllUser().subscribe((res:any)=>{
      console.log(res);
      this.lstuser=res;
    })
  }

}
