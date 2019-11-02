import { Sector } from '../models/Sector.model';

import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { observable, Observable } from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})

export class SectorService {
  formData: Sector;
  readonly rootURL = 'https://localhost:44355';

  constructor(private http: HttpClient) { }

  PostSector(formData: Sector): Observable<any> {
    return this.http.post(this.rootURL + '/sector', formData, httpOptions);
  }
}
