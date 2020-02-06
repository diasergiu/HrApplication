import { Component, OnInit } from '@angular/core';
import { CandidateComponent } from '../candidate/candidate.component';

@Component({
  selector: 'app-candidate-list',
  templateUrl: './candidate-list.component.html',
  styleUrls: ['./candidate-list.component.css']
})
export class CandidateListComponent implements OnInit {

  candidateList : CandidateComponent[];

  constructor() { }

  ngOnInit() {
  }

  public add(Candidate : CandidateComponent){
    this.candidateList.push(Candidate);
  }

}
