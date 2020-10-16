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
export class FeedService {

  private add = environment.apiEndpoint + "/api/Feed/AddFeed";
  private GetAll = environment.apiEndpoint + "/api/Feed/GetAllFeed";
  private Delete = environment.apiEndpoint + "/api/Feed/Delete";

 
  constructor(private http : HttpClient,private tokenservice:TokenService,private route:Router) { 
    
  }

  public AddFeed(feed: any) {
    return this.http.post(this.add, feed);
  }
  public GetAllFeed() {
    return this.http.get(this.GetAll);
  }
  public DeleteFeed(id: number) {
    return this.http.post(this.Delete, id);
  }
  
}
