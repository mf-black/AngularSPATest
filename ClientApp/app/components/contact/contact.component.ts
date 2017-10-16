import { Component } from '@angular/core';
import { ContactService } from '../../providers/services';
import { Contact } from '../../providers/contact-type';

@Component({
    selector: 'contact',
    templateUrl: './contact.component.html'
})
export class ContactComponent {
    contacts: Contact[];

    constructor(private contactService: ContactService) {
        this.getContacts();
        console.log(this.contacts);
    }      

    getContacts(): void {
        this.contactService.getContactList().then(contacts => this.contacts = contacts);
    }


}

