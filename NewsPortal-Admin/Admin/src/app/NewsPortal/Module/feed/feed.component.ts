import { Component, OnInit } from '@angular/core';
import { FeedService } from '../../api-service/feed/feedservice.service';

@Component({
  selector: 'app-feed',
  templateUrl: './feed.component.html',
  styleUrls: ['./feed.component.css']
})
export class FeedComponent implements OnInit {
public lstfeed:[];
  constructor(private feedservice:FeedService) { }

  ngOnInit(): void {
    this.GetAllUser();

  }

  GetAllUser(){
    this.feedservice.GetAllFeed().subscribe((res:any)=>{
      console.log(res);
      this.lstfeed=res;
    })
  }

}
