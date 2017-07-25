import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public people: Person[];

    constructor(http: Http, @Inject('ORIGIN_URL') originUrl: string) {
        http.get(originUrl + '/api/Person/ListPeople').subscribe(result => {
            this.people = result.json() as Person[];
        });
    }
}

interface Person {
    firstName: string;
    lastName: string;
    dateOfBirth: Date;
    height: number;
    weight: number;
}
