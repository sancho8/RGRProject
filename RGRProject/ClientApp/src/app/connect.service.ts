import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, pipe, from, of, range, timer, BehaviorSubject, } from 'rxjs';
import { map, tap, retryWhen, delay, take, zip, mergeMap} from 'rxjs/operators';
import { ajax } from 'rxjs/ajax';


const BaseUrl = 'http://52.233.138.86:8097/api/v1';
export const LOAD_INTERVAL_MS = 100; // 100 ms
export const MAX_INTERVAL_MS = 2 * 1000; // 2 sec

@Injectable()
export class ConnectService {
places: BehaviorSubject<any> = new BehaviorSubject([]);
place: BehaviorSubject<any> = new BehaviorSubject([]);
data = this.places.asObservable();
currentPlace = this.place.asObservable();

constructor(private http: HttpClient) { }


  backoff(maxTries, ms) {
    return pipe(
      retryWhen(attempts => range(1, maxTries)
        .pipe(
          zip(attempts, (i) => i),
          map(i => i * i),
          mergeMap(i =>  timer(i * ms))
        )
      )
    )  
  };

  getPlaceProfile(id) {
    ajax(`http://52.233.138.86:8097/api/v1/GetPlace/${id}`)
    .pipe(
      this.backoff(3, 250),
    )
    .subscribe(data => {
      
    });
  }



  getPlaces(){
      ajax('http://52.233.138.86:8097/api/v1/GetPlaces')
      .pipe(
        this.backoff(3, 250),
      )
      .subscribe((data: any) => {
        console.log(data);
        this.places.next(data.response.data);
      });

  }

  bookPlace(data) {
    ajax({url: `${BaseUrl}/BookPlace`, body: data })
      .pipe(this.backoff(3, 250))
      .subscribe(res => {
        console.log(res);
      });
  }


}
