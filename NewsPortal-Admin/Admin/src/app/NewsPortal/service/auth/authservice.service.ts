import { Injectable } from '@angular/core';
import{environment} from '../../../../environments/environment';
import{User} from '../../Model/Auth/registration';
import { HttpClient } from '@angular/common/http';
import { Login } from '../../Model/Auth/login';
import { TokenService } from '../../service/token/token.service';
import { Router } from '@angular/router';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private addUser = environment.apiEndpoint + "/api/User/AddUser";
  private getAllUser = environment.apiEndpoint + "/api/User/GetAllUser";
  private loginUser = environment.apiEndpoint + "/api/Auth/Login";



  constructor(private http : HttpClient,private tokenservice:TokenService,private route:Router) { 
    
  }

  public AddUser(user: User) {
    return this.http.post(this.addUser, user);
  }

  public LoginUser(login: any) {

    const body = {
      Username: login.Username,
      Password: login.Password
    };

    return this.http.post(this.loginUser, body).pipe(map((res: any) => {
      this.tokenservice.SaveToken(res.Token);
      // this.userIdleService.startWatching();
    }));
  }

  public GetAllUser() {
    return this.http.get(this.getAllUser);
  }


  logout() {
    this.http.post("", '').subscribe(res => {
      this.removeToken();
    }, error => {
      this.removeToken();
    });
  }

  public removeToken() {
    this.tokenservice.RemoveToken();
    // this.userIdleService.stopWatching();
    this.route.navigate(['/login']);

  }


  changePassword(changePasswordData: any) {
    return this.http.post("", changePasswordData);
  }

  /* Method for request reset password when forgot password
  * @Parameter user email
  * @Return Response string
  */
  // forgotPassword(data) {
  //   return this.http.post(this.serverPath + '', data).map(response => response.json());
  // }

  /* Method for Reset password
  * @Parameter email, new password, confirm password
  * @Return Response string
  */
  resetPassword(data: any) {
    return this.http.post("", data);
  }

  /* Method for Checked that claimed user is authenticate or not ?
  * @Parameter No parameter
  * @Return Boolean
  */
  checkLogged() {
    if (this.tokenservice.GetToken()) {
      return !this.tokenservice.isTokenExpired();
    } else {
      return false;
    }
  }

  getLoggedUsername() {
    if (this.tokenservice.GetToken()) {
      return this.tokenservice.GetTokenValue("UserName");
    }
    return '';
  }

  getLoggedAccessRight() {
    if (this.tokenservice.GetToken()) {
      return this.tokenservice.GetTokenValue("role");
    }
    return '';
  }

  getLoggedSessionId() {
    if (this.tokenservice.GetToken()) {
      return this.tokenservice.GetTokenValue("");
    }
    return '00000000-0000-0000-0000-000000000000';
  }

  // getLoggedUserType(): number {
  //   if (this.tokenService.GetToken()) {
  //     return Number(this.tokenService.GetTokenValue('user_type'));
  //   }
  //   return 0;
  // }

  getLoggedEmail() {
    if (this.tokenservice.GetToken()) {
      return this.tokenservice.GetTokenValue("Email");
    }
    return '';
  }

  public RemoveToken() {
    this.tokenservice.RemoveToken();
  }

}
