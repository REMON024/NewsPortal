import {Component, OnInit} from '@angular/core';
import { navItems } from '../../../../_nav';
import { AuthService } from '../../../service/auth/authservice.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './default-layout.component.html'
})
export class LayoutComponent implements OnInit {
  public sidebarMinimized = false;
  public navItems = navItems;
  public loginstatus=false;
  public reader=true;


  constructor(private authservice:AuthService){

  }

  ngOnInit(): void {
    this.isLogin();
    this.isNotReader();

  }

  refresh(): void {
    window.location.reload();
}
  toggleMinimize(e) {
    this.sidebarMinimized = e;
  }

  isLogin(){
   this.loginstatus= this.authservice.checkLogged()
   console.log(this.loginstatus)

  }
  isNotReader(){
    let role=this.authservice.getLoggedAccessRight()
    if(role!="Reader"){
      this.reader=false;
    }
    console.log(this.reader)
  }

  logout(){
    this.authservice.logout();

  }

  Logout(){
    let res= this.authservice.logout()
    console.log(res)
   }
}
