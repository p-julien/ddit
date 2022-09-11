import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Reddit } from '../models/reddit.model';

@Injectable({
  providedIn: 'root',
})
export class RedditService {
  constructor(private http: HttpClient) {}

  getReddits() {
    return this.http.get<Reddit[]>(environment.baseUrl + '/reddits');
  }
}
