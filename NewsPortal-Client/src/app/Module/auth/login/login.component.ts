import { Component, OnInit } from '@angular/core';
import { Login } from '../../../Model/Auth/login';
import { AuthService } from '../../../Service/auth/authservice.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public login:Login=new Login();

  constructor(private authservice:AuthService) { }

  ngOnInit(): void {
  }

  onSubmit() 
  {
      this.authservice.LoginUser(this.login);
          // response => 
          // {     console.log(response,"Login Response")
          //     // if (response.Token == null && response.Usertype == "0") 
          //     // {
          //     //     let config = new MatSnackBarConfig();
          //     //     config.duration = this.setAutoHide ? this.autoHide : 0;
          //     //     config.verticalPosition = this.verticalPosition;
                
          //     //     this.snackBar.open("Invalid Username and Password", this.action ? this.actionButtonLabel : undefined, config);

          //     //     this._Route.navigate(['Login']);
          //     // }

          //     // if (response.Usertype == "1") 
          //     // {
          //     //     let config = new MatSnackBarConfig();
          //     //     config.duration = this.setAutoHide ? this.autoHide : 0;
          //     //     config.verticalPosition = this.verticalPosition;
                
          //     //     this.snackBar.open("Logged in Successfully", this.action ? this.actionButtonLabel : undefined, config);

          //     //     this._Route.navigate(['/Admin/Dashboard']);
          //     // }

          //     // if (response.Usertype == "2") 
          //     // {
          //     //     let config = new MatSnackBarConfig();
          //     //     config.duration = this.setAutoHide ? this.autoHide : 0;
          //     //     config.verticalPosition = this.verticalPosition;
                
          //     //     this.snackBar.open("Logged in Successfully", this.action ? this.actionButtonLabel : undefined, config);
          //     //     this._Route.navigate(['/User/Dashboard']);
          //     // }
          // });

  }

}
