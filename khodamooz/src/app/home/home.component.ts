import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { SignupComponent } from '../auth/signup/signup.component';
import { MdDialog } from '@angular/material';
import { SigninComponent } from '../auth/signin/signin.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  constructor(private httpService: Http, private dialog: MdDialog) { }
  apiValues: string[] = [];


  openLogin() {
      this.dialog.open(SigninComponent, {
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
