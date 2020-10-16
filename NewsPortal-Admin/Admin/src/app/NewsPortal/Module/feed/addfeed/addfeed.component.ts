import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AngularEditorConfig } from '@kolkov/angular-editor';
import { Feed } from '../../../Model/Feed/feed';
import { FeedService } from '../../../api-service/feed/feedservice.service';
import { angularEditorConfig } from '@kolkov/angular-editor/lib/config';

@Component({
  selector: 'app-addfeed',
  templateUrl: './addfeed.component.html',
  styleUrls: ['./addfeed.component.css']
})
export class AddFeedComponent implements OnInit {
  
  public htmlContent = '';

  public feed:Feed=new Feed();
  constructor(private feedservice:FeedService,private _Route: Router) { }

  ngOnInit(): void {
  }

  Submit(){
    console.log(this.feed)
    this.feedservice.AddFeed(this.feed).subscribe((res:any)=>{
      this._Route.navigate(['feed']);


    })
  }

  change(event){
console.log(this.feed.isHeadline,"event")  }
  config: AngularEditorConfig = {
    editable: true,
    spellcheck: true,
    height: '15rem',
    minHeight: '5rem',
    placeholder: 'Enter text here...',
    translate: 'yes',
    defaultParagraphSeparator: 'p',
    defaultFontName: 'Arial',
    toolbarHiddenButtons: [
      ['bold']
      ],
    customClasses: [
      {
        name: "quote",
        class: "quote",
      },
      {
        name: 'redText',
        class: 'redText'
      },
      {
        name: "titleText",
        class: "titleText",
        tag: "h1",
      },
    ]
  };

}
