import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddFeedComponent } from '../feed/addfeed/addfeed.component';

import {FeedComponent } from '../feed/feed.component';

const routes: Routes = [
  { path: '', component: FeedComponent },
  { path: 'add', component: AddFeedComponent },
  { path: 'edit/:id', component: AddFeedComponent },


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FeedComponentRoutingModule { }
