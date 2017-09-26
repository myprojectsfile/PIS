import { SignupComponent } from './signup/signup.component';
import { SigninComponent } from './signin/signin.component';
import { Injectable } from '@angular/core';
import { JwtHelper } from 'angular2-jwt';
import { MdDialog, MdSnackBar } from '@angular/material';

@Injectable()
export class AuthService {

  constructor(private dialog: MdDialog, private jwtHelper: JwtHelper, private snackBar: MdSnackBar) { }

  signIn() {
    let dialogRef = this.dialog.open(SigninComponent, {
      height: '270px',
      width: '400px',
      position: {
        top: '2%'
      }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.isSignedIn();
        this.snackBar.open('خوش آمدید', null, { duration: 2000 });
      }
    });
  }

  signUp() {
    let dialogRef = this.dialog.open(SignupComponent, {
      height: '270px',
      width: '400px',
      position: {
        top: '2%'
      }
    });
  }

  isSignedIn() {
    let tokenObject = JSON.parse(localStorage.getItem('token'));
    if (tokenObject) {
      let token = tokenObject.token;
      console.log('decoded token is:' + JSON.stringify(this.jwtHelper.decodeToken(token)));
      if (this.jwtHelper.isTokenExpired(token))
        return false;
      else return true;
    }
    return false;
  }

  signOut() {
    localStorage.removeItem('token');
    this.isSignedIn();
  }
}
