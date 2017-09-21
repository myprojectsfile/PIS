import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  constructor(private authService: AuthService) {
  }

  username = '';
  password = '';

  onLogin() {
    this.authService.login(this.username, this.password)
      .subscribe(res => {
        if (res.ok && res.status === 200) {
          console.log('login succeeded');
        } else if (!res.ok && res.status === 401) {
          console.log('user or password is not correct');
        } else {
          console.log('failed in login operation.');
        }
      }, error => {
        console.log('user or password is not correct');
      });
  }
}
