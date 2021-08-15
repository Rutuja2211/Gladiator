import { Component, OnInit } from '@angular/core';
import { ContactService } from '../service/contactService';
import { Contact } from '../model/contact';

@Component({
  selector: 'app-addcontact',
  templateUrl: './addcontact.component.html',
  styleUrls: ['./addcontact.component.css']
})
export class AddcontactComponent implements OnInit {

contact:Contact;
  constructor(private contactService:ContactService)
  { 
    this.contact=new Contact();
  }


  addContact()
  {
    this.contactService.addContact(this.contact);
    this.contact=new Contact();
    //also route back to main page
  }
  

  ngOnInit(): void {
  }

}
