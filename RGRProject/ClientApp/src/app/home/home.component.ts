import { ConnectService } from './../connect.service';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription, Observable, range, timer, pipe} from 'rxjs';
import { map, tap, retryWhen, delay, take, zip, mergeMap} from 'rxjs/operators';
import { ajax } from 'rxjs/ajax';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit, OnDestroy {
  places: any = [];
  isLoaded = false;
  constructor(private connectService: ConnectService, private router: Router){

  }
  ngOnInit(){
    this.connectService.getPlaces();
    this.connectService.data
    .subscribe(res => {
      if(res){
        this.places = res || [];
        this.isLoaded = true;
      }         
    });

  }

  bookPlace(id){
    this.router.navigateByUrl(`book/${id}`);
  }

  ngOnDestroy(){
    // this.getSub.unsubscribe();
  }


  

  
}
