import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Reddit } from './models/reddit.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  reddits: Reddit[] = [];
  error: string = '';

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get<Reddit[]>(environment.baseUrl + '/reddits').subscribe({
      next: (v) => (this.reddits = v),
      error: (e) => (this.error = e.message),
    });
  }
}
