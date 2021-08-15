import { Component, OnInit } from '@angular/core';
import { ContactService } from '../service/contactService';
import { Contact } from '../model/contact';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent implements OnInit {
last:string;
contacts:Contact[];

constructor(private contactService:ContactService) 
{
  this.contacts=this.contactService.getAllContacts();
}

ngOnInit(): void {
  
}

}
