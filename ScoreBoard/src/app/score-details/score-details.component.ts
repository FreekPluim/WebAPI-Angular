import { Component, OnInit } from '@angular/core';
import { ScoreDetail } from '../shared/score-detail.model';
import { ScoreDetailService } from '../shared/score-detail.service';


@Component({
  selector: 'app-score-details',
  templateUrl: './score-details.component.html',
  styles: [
  ]
})
export class ScoreDetailsComponent implements OnInit {

  constructor(public service: ScoreDetailService) { }


  ngOnInit(): void {
    this.service.refreshList();
  }

  deleteScore(id: number){
    this.service.deleteScore(id)
    .subscribe( 
      response => {
        this.service.refreshList()
    });
  }

}
