import { Injectable } from '@angular/core';
import { Http, RequestOptions, Headers , Response} from '@angular/http';
import 'rxjs/add/operator/map';
import { Observable } from "rxjs/Observable";

@Injectable()
export class AuthService {

    constructor(private http: Http) { }

    login(username: string, password: string):Observable<Response> {
        var credential = {
            username: username,
            password: password
        };

        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });

        return this.http.post("http://localhost:4200/api/auth/getToken", JSON.stringify(credential), options);
    }
}
