import { Injectable } from '@angular/core';
import { ScoreDetail } from './score-detail.model';
import {HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class ScoreDetailService {

  constructor(private http:HttpClient) { }

  formData:ScoreDetail = new ScoreDetail();
  readonly baseURL = 'http://localhost:5000/api/ScoreDetail'
  list: ScoreDetail[];

  postScoreDetail(){
    this.getHighscore();
    return this.http.post(this.baseURL, this.formData)
  }

  getHighscore(){
    this.formData.highScore = (this.formData.distanceInMeters * 10) - (this.formData.scoreTimeinSec * 5);

    if(this.formData.highScore < 0) this.formData.highScore = 0;
  }

  deleteScore(id:number){
    return this.http.delete<ScoreDetail>(this.baseURL + '/' + id)
  }

  refreshList(){
    this.http.get(this.baseURL).toPromise().then(
      res=> this.list = res as ScoreDetail[]
      );
  }
}
