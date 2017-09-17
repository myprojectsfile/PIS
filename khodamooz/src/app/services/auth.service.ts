import { Injectable } from '@angular/core';
import { Http, RequestOptions,Headers } from '@angular/http';
import 'rxjs/add/operator/map';
import { Observable } from "rxjs/Observable";

@Injectable()
export class AuthService {

    constructor(private http: Http) { }

    login(username: string, password: string) {
        var credential = {
            username: username,
            password: password
        };

        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });

        this.http.post("http://localhost:4200/api/auth/getToken", JSON.stringify(credential),options)
            .subscribe(data => console.log(data));
    }
}
