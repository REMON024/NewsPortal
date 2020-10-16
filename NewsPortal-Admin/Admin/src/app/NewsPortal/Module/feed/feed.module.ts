import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import {  FeedComponentRoutingModule } from './feed-routing.module';
import { FeedComponent } from './feed.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AddFeedComponent } from './addfeed/addfeed.component';

import { AngularEditorModule } from '@kolkov/angular-editor';
import { FeedService } from '../../api-service/feed/feedservice.service';
@NgModule({
  declarations: [FeedComponent, AddFeedComponent],

  imports: [
    CommonModule,
    FeedComponentRoutingModule,
    HttpClientModule,
    FormsModule,
    AngularEditorModule
  ],providers:[FeedService]
})
export class FeedModule { }
