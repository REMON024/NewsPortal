import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RoleService } from '../../../api-service/role/roleservice.service';
import { Role } from '../../../Model/role';

@Component({
  selector: 'app-addrole',
  templateUrl: './addrole.component.html',
  styleUrls: ['./addrole.component.css']
})
export class AddRoleComponent implements OnInit {

  public role:Role=new Role();
  constructor(private roleservice:RoleService,private _Route: Router) { }

  ngOnInit(): void {
  }

  Submit(){
    this.roleservice.AddRole(this.role).subscribe((res:any)=>{
      this._Route.navigate(['role']);


    })
  }

}
