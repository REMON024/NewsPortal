import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddCategoryComponent } from './addcategory/addcategory.component';

import { CategoryComponent } from './category.component';

const routes: Routes = [
  { path: '', component: CategoryComponent },
  { path: 'add', component: AddCategoryComponent },
  { path: 'edit/:id', component: AddCategoryComponent },


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CategoryComponentRoutingModule { }
