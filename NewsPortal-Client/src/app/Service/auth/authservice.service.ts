import { Injectable } from '@angular/core';
import{environment} from '../../../environments/environment';
import{User} from '../../Model/Auth/regitrstion';
import { HttpClient } from '@angular/common/http';
import { Login } from '../../Model/Auth/login';


@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private addUser = environment.apiEndpoint + "/api/User/AddUser";
  private getAllUser = environment.apiEndpoint + "/api/User/GetAllUser";
  private loginUser = environment.apiEndpoint + "/api/Auth/Login";



  constructor(private http : HttpClient) { 
    
  }

  public AddUser(user: User) {
    return this.http.post(this.addUser, user);
  }

  public LoginUser(login: Login) {
    return this.http.post(this.loginUser, login);
  }

  public GetAllUser() {
    return this.http.get(this.getAllUser);
  }
}
