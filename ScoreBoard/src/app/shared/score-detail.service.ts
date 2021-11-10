import { Injectable } from '@angular/core';
import { ScoreDetail } from './score-detail.model';
import {HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class ScoreDetailService {

  constructor(private http:HttpClient) { }

  formData:ScoreDetail = new ScoreDetail();
  readonly baseURL = 'http://localhost:60145/api/ScoreDetail'
  list: ScoreDetail[];

  postScoreDetail(){
    return this.http.post(this.baseURL, this.formData)
  }

  refreshList(){
    this.http.get(this.baseURL).toPromise().then(
      res=> this.list = res as ScoreDetail[]
      );
    
  }
}
