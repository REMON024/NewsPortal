import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CategoryService } from '../../../api-service/category/categoryservice.service';
import { Category } from '../../../Model/category/category';

@Component({
  selector: 'app-addcategory',
  templateUrl: './addcategory.component.html',
  styleUrls: ['./addcategory.component.css']
})
export class AddCategoryComponent implements OnInit {

  public category:Category=new Category();
  constructor(private categoryservice:CategoryService,private _Route: Router) { }

  ngOnInit(): void {
  }

  Submit(){
    this.categoryservice.AddCategory(this.category).subscribe((res:any)=>{
      this._Route.navigate(['category']);


    })
  }

}
