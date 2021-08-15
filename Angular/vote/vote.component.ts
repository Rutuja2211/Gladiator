import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vote',
  templateUrl: './vote.component.html',
  styleUrls: ['./vote.component.css']
})
export class VoteComponent implements OnInit {
  age:number;
  voteClass:string="display";
  eligibility:string;
  constructor() {
    console.log(this.age);
    
   }

  

   getClass()
   {  
     if(this.age>18)
     { 
      return this.voteClass="display vote";
     }
      
    else
    { 
      
      return this.voteClass="display novote";
    }
     
   }

  ngOnInit(): void {
    
  }

}
