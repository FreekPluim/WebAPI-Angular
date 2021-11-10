import { Component, OnInit } from '@angular/core';
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

}
