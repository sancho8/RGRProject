import { ConnectService } from './../connect.service';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription, Observable, range, timer, pipe} from 'rxjs';
import { map, tap, retryWhen, delay, take, zip, mergeMap} from 'rxjs/operators';
import { ajax } from 'rxjs/ajax';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit, OnDestroy {
  places: any = [];
  isLoaded = false;
  constructor(private connectService: ConnectService){

  }
  ngOnInit(){
    this.connectService.getPlaces();
    this.connectService.data
    .subscribe(res => {
      if(res){
        this.places = res || [];
        this.isLoaded = true;
      }
      console.log(this.places);         
    });

  }

  ngOnDestroy(){
    // this.getSub.unsubscribe();
  }


  

  
}
