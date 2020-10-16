import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CategoryComponentRoutingModule } from './category-routing.module';
import { CategoryComponent } from './category.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import {  AddCategoryComponent } from '../category/addcategory/addcategory.component';
import { CategoryService } from '../../api-service/category/categoryservice.service';


@NgModule({
  declarations: [CategoryComponent, AddCategoryComponent],

  imports: [
    CommonModule,
    CategoryComponentRoutingModule,
    HttpClientModule,
    FormsModule
  ],providers:[CategoryService]
})
export class CategoryModule { }
