import { Injectable } from '@angular/core';
import { Contact } from '../model/contact';

@Injectable()
export class ContactService
{   
    contacts:Contact[];
    constructor()
    {
        this.contacts=[
            new Contact("Ana","Gale","111-111-111"),
            new Contact("Hana","Potter","222-222-222"),
            new Contact("Dana","Swans","333-333-333"),
            new Contact("Lana","Wayne","555-555-555"),
            new Contact("Nana","Scott","444-444-444"),
        ];
    }

    getContactsBySurname(last:string):Contact[]
    {
        for (let index = 0; index < this.contacts.length; index++) {
            if(this.contacts[index].lastname==last)
                this.contacts.push(this.contacts[index]);
        }
       return this.contacts;
    }


    getAllContacts():Contact[]
    {
        return this.contacts;
    }

    addContact(contact:Contact):boolean
    {   
        for (let index = 0; index < this.contacts.length; index++) {
            if(this.contacts[index].firstname==contact.firstname && this.contacts[index].lastname==contact.lastname)
                return false;
        }

        this.contacts.push(contact);
        return true;
    }

    deleteContact(contact:Contact)
    {
        for (let index = 0; index < this.contacts.length; index++) {
            if(this.contacts[index].firstname==contact.firstname && this.contacts[index].lastname==contact.lastname &&
                this.contacts[index].phone==contact.phone)
                this.contacts.splice(index,1);
        }
    }
}