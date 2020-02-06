import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-candidate',
  templateUrl: './candidate.component.html',
  styleUrls: ['./candidate.component.css']
})
export class CandidateComponent implements OnInit {

  id : number;
  salary : number;
  expectedSalary : number;
  firstName : string;
  lastName : string;
  status : string;

  constructor() { }

  ngOnInit() {
  }

}
