import { Component, OnInit } from '@angular/core';
import { ContactService } from '../../providers/services';
import { Contact } from '../../providers/contact-type';

@Component({
    selector: 'contact',
    templateUrl: './contact.component.html'
})
export class ContactComponent /*implements OnInit*/ {
    contacts: Contact[];

    constructor(private contactService: ContactService) {
        this.getContacts();
        
    }      

    getContacts(): void {
        this.contactService.getContactList().then(contacts => this.contacts = contacts);
        console.log(this.contacts);
    }

    //ngOnInit(): void {
    //    this.getContacts();
    //    console.log(this.contacts);
    //}
}

