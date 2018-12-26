import { ConnectService } from './../connect.service';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit, OnDestroy {
  getSub: Subscription;

  constructor(private connectService: ConnectService){

  }
  ngOnInit(){
    this.getSub =  this.connectService.getPlaces()
      .subscribe(res => {
        console.log(res);
      });
  }

  ngOnDestroy(){
    this.getSub.unsubscribe();
  }
}
