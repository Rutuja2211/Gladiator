import { Pipe, PipeTransform } from '@angular/core';
import { Contact } from './model/contact';

@Pipe({
  name: 'surnameFilter'
})
export class SurnameFilterPipe implements PipeTransform {

  transform(contacts: Contact[], name:string): Contact[] {
    if(!contacts || !name){
      return contacts;
    }
  
    return contacts.filter(contact=>
        contact.lastname.toLowerCase().indexOf(name.toLowerCase())  !==-1 );
  }

}