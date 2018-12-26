import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

const BaseUrl = 'http://52.233.138.86:8097/api/v1';
@Injectable()
export class ConnectService {


constructor(private http: HttpClient) { }

  getPlaces(): Observable<any> {
    return this.http.get<any>(`${BaseUrl}/GetPlaces`) 
  }

  getPlaceProfile(id): Observable<any> {
    return this.http.get<any>(`${BaseUrl}/GetPlace/${id}`) 
  }

  bookPlace(data): Observable<any> {
    return this.http.post<any>(`${BaseUrl}/BookPlace`, {...data}) 
  }

}
