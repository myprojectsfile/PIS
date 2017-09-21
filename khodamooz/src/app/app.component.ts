import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { SignupComponent } from './auth/signup/signup.component';
import { LoginComponent } from './auth/login/login.component';
import { MdDialog } from '@angular/material';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    constructor(private httpService: Http, private dialog: MdDialog) { }
    apiValues: string[] = [];


    openLogin() {
        this.dialog.open(LoginComponent, {
            height: '270px',
            width: '400px',
            position: {
                top: '2%'
            }
        });
    }

    openSignup() {
        this.dialog.open(SignupComponent, {
            height: '270px',
            width: '400px',
            position: {
                top: '2%'
            }
        });
    }
}
