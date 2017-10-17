import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/Rx';

import { Contact } from './contact-type';

@Injectable()
export class ContactService {
    constructor(private http: Http) {

    }

    getContactList(): Promise<Contact[]> {
        return this.http.get('http://localhost:58054/api/contacts')
            .toPromise()
            .then(response => response.json() as Contact[])
            .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error); // for demo purposes only
        return Promise.reject(error.message || error);
    }
}
