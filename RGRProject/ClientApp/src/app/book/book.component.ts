import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { take } from 'rxjs/operators';
import { ConnectService } from 'app/connect.service';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {
  id: number;
  data: any;
  tempForm: FormGroup;
  submitted: boolean = false;
  success = false;
  error = '';

  controls: any = {
    id: '',
    placeId: '',
    customerName: ['', Validators.required],
    customerContact:  '',
    bookingStart:  '',
    bookingFinish:  '',
    rating: '',
    status: 1
  }
  times: any[] = [
    {time: 0},
    {time: 0},
  ];
  constructor(private activatedRoute: ActivatedRoute, private connectService: ConnectService, private fb: FormBuilder) {
    activatedRoute.params.pipe(take(1)).subscribe(params => {
      const id = params['id'];
      this.id = params['id'];
    })
   }

  ngOnInit() {
    this.connectService.getPlaceProfile(this.id);
    this.tempForm = this.fb.group(this.controls);
    this.tempForm.get('placeId').setValue(this.id);
  }
  formatSchedule(): void{
    const regEnd = this.tempForm.get('bookingStart').value;
    this.tempForm.get('bookingStart').setValue(`${regEnd.year}-${regEnd.month}-${regEnd.day} ${this.times[0].time.hour}:${this.times[0].time.minute}:${this.times[0].time.second}`);
    const tour = this.tempForm.get('bookingFinish').value;
    this.tempForm.get('bookingFinish').setValue(`${tour.year}-${tour.month}-${tour.day} ${this.times[1].time.hour}:${this.times[1].time.minute}:${this.times[1].time.second}`);
  }

  onSubmit(){
    this.formatSchedule();
    this.data = this.tempForm.value;
    this.connectService.bookPlace(this.data);
    console.log(this.data);
  }

}
