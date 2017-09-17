import { Component, OnInit, Input } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { AuthService } from '../../services/auth.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
    @Input() name;
    constructor(public activeModal: NgbActiveModal, private authService:AuthService) { }

    ngOnInit() {
    }

    onLogin() {
        this.authService.login("mohammad", "P@ssword123");
    }
}
