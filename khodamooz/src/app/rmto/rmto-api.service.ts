import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs/Observable';
import { Http, RequestOptions, Headers, Response } from '@angular/http';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Container } from './container';

@Injectable()
export class RmtoApiService {

  constructor(private http: HttpClient) { }

  getReceiptsContainers(receiptsNoString: string): Observable<Container[]> {

    const apiUri = window.location.origin;

    const headers = new HttpHeaders().set('Content-Type', 'application/json');

    return this.http.post<any[]>(apiUri + '/api/CCS/GetReceiptsContainers', receiptsNoString, {headers: headers});
  }

}

