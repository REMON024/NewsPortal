import { Component, OnInit } from '@angular/core';
import { RoleService } from '../../api-service/role/roleservice.service';

@Component({
  selector: 'app-role',
  templateUrl: './role.component.html',
  styleUrls: ['./role.component.css']
})
export class RoleComponent implements OnInit {
public lstrole:[];
  constructor(private roleservice:RoleService) { }

  ngOnInit(): void {
    this.GetAllUser();

  }

  GetAllUser(){
    this.roleservice.GetAllRole().subscribe((res:any)=>{
      console.log(res);
      this.lstrole=res;
    })
  }

}
