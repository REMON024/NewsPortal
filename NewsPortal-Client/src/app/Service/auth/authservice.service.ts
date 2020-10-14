import { Injectable } from '@angular/core';
import{environment} from '../../../environments/environment';
import{User} from '../../Model/Auth/regitrstion';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private addUser = environment.apiEndpoint + "/api/User/AddUser";
  private getAllUser = environment.apiEndpoint + "/api/User/GetAllUser";


  constructor(private http : HttpClient) { 
    
  }

  public AddUser(user: User) {
    return this.http.post(this.addUser, user);
  }

  public GetAllUser() {
    return this.http.get(this.getAllUser);
  }
}
