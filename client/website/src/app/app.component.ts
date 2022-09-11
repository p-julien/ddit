import { Component, OnInit } from '@angular/core';
import { Reddit } from './models/reddit.model';
import { RedditService } from './services/reddit.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  reddits: Reddit[] = [];

  constructor(private redditService: RedditService) {}

  ngOnInit(): void {
    this.redditService
      .getReddits()
      .subscribe((reddits) => (this.reddits = reddits));
  }
}
