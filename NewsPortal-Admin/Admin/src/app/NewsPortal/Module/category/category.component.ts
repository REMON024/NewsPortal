import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../../api-service/category/categoryservice.service';

@Component({
  selector: 'app-role',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {
public lstcategory:[];
  constructor(private categoryservice:CategoryService) { }

  ngOnInit(): void {
    this.GetAllUser();

  }

  GetAllUser(){
    this.categoryservice.GetAllCategory().subscribe((res:any)=>{
      console.log(res);
      this.lstcategory=res;
    })
  }

}
