import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-likedislike',
  templateUrl: './likedislike.component.html',
  styleUrls: ['./likedislike.component.css']
})
export class LikedislikeComponent implements OnInit {

constructor() { }

likes=100;
dislikes=25;
likeClass="like-button";
dislikeClass="dislike-button";
likeflag=false;
dislikeflag=false;

onLikeClick()
{   
  
  if(this.likeflag==true)//liked already
  {
    this.likes--;
    this.likeClass="like-button";
    this.likeflag=false;
  }
  else
  {
    this.likes++;
    this.likeClass="like-button liked";
    this.likeflag=true;
  }
  if(this.dislikeflag==true)
  {
    this.dislikes--;
    this.dislikeClass="dislike-button";
    this.dislikeflag=false;
  }
}

onDislikeClick()
{ 
  if(this.dislikeflag==true)//disliked already
  {
    this.dislikes--;
    this.dislikeClass="dislike-button";
    this.dislikeflag=false;
  }
  else
  {
    this.dislikes++;
    this.dislikeClass="dislike-button disliked";
    this.dislikeflag=true;
  }
  if(this.likeflag==true)
  {
    this.likes--;
    this.likeClass="like-button";
    this.likeflag=false;
  }
}


  ngOnInit(): void {
  }

}
