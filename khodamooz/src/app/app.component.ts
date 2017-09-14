import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'
import { LoginComponent } from "./auth/login/login.component";
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
   selector: 'app-root',
   templateUrl: './app.component.html',
   styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(private httpService: Http, private modalService: NgbModal) { }
   apiValues: string[] = [];
   ngOnInit() {
      this.httpService.get('/api/values').subscribe(values => {
         this.apiValues = values.json() as string[];
      });
   }

  openModal() {
    const modalRef = this.modalService.open(LoginComponent);
    modalRef.componentInstance.name = 'دنبا';
  }
}
