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
export class CategoryService {

  private add = environment.apiEndpoint + "/api/Category/AddCategory";
  private GetAll = environment.apiEndpoint + "/api/Category/GetAllCategory";
  private Delete = environment.apiEndpoint + "/api/Category/Delete";

 
  constructor(private http : HttpClient,private tokenservice:TokenService,private route:Router) { 
    
  }

  public AddCategory(category: any) {
    return this.http.post(this.add, category);
  }
  public GetAllCategory() {
    return this.http.get(this.GetAll);
  }
  public DeleteCategory(id: number) {
    return this.http.post(this.Delete, id);
  }
  
}
