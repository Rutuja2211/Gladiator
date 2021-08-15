import { Component, OnInit, Input } from '@angular/core';
import { Contact } from '../model/contact';
import { ContactService } from '../service/contactService';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  @Input('myContact') contact:Contact;
  constructor(private contactService:ContactService) { 
  }


  deleteContact(contact:Contact)
  {
    this.contactService.deleteContact(contact);
  }

  ngOnInit(): void {
  }

}
