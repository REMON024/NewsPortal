import { Injectable } from '@angular/core';
import{environment} from '../../../../environments/environment';
import{User} from '../../Model/Auth/registration';
import { HttpClient } from '@angular/common/http';
import { Login } from '../../Model/Auth/login';
import { TokenService } from '../../service/token/token.service';
import { Router } from '@angular/router';
import { map } from 'rxjs/operators';
import { Role } from '../../Model/role';


@Injectable({
  providedIn: 'root'
})
export class RoleService {

  private add = environment.apiEndpoint + "/api/Role/AddRole";
  private GetAll = environment.apiEndpoint + "/api/Role/GetAllRole";
  private Delete = environment.apiEndpoint + "/api/Role/Delete";

 
  constructor(private http : HttpClient,private tokenservice:TokenService,private route:Router) { 
    
  }

  public AddRole(role: Role) {
    return this.http.post(this.add, role);
  }
  public GetAllRole() {
    return this.http.get(this.GetAll);
  }
  public DeleteRole(id: number) {
    return this.http.post(this.Delete, id);
  }
  
}
