import { Component, OnInit } from '@angular/core';
import { ScoreDetailService } from 'src/app/shared/score-detail.service';
import {NgForm} from "@angular/forms";
import { ScoreDetail } from 'src/app/shared/score-detail.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-score-details-form',
  templateUrl: './score-details-form.component.html',
  styles: [
  ]
})
export class ScoreDetailsFormComponent implements OnInit {

  constructor(public service:ScoreDetailService,
    private toastr:ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm){
    this.service.postScoreDetail().subscribe(
      res => {
  

        this.resetForm(form);
        this.toastr.success('Score submitted successfully', 'Score Detail Register');
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    );
  }

  resetForm(form:NgForm){
    form.form.reset();
    this.service.formData = new ScoreDetail();
  } 

  

}
