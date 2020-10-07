import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css']
})
export class TaskComponent implements OnInit {
  username="";
  JsonData=[
    '{id=1,name=Arpit,competancy= .Net}',
    '{id=2,name=Abhishek,competancy= .Net}',
    '{id=3,name=Sarvesh,competancy= MEAN}',
    '{id=4,name=Azeem,competancy= .Net}',
    '{id=5,name=Vishesh,competancy=.Net}'
  ];

  log=[];

  showData= false;
  constructor() { }

  ngOnInit(): void {
  }
  onToggleDetails(){
    this.showData=!this.showData;
    
    this.log.push(this.JsonData);

  }

}
