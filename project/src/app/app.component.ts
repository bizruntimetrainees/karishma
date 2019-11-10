import { Component, Inject,HostListener, Input } from '@angular/core';

import { MyserviceService } from './myservice.service';
import {FormControl} from '@angular/forms';
import {CommonModule} from '@angular/common';
  import { from } from 'rxjs';



export enum KEY_CODE {
  RIGHT_ARROW = 1,
  LEFT_ARROW = 0
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
   })
   export class AppComponent 
{
   private _startDate = new Date(2019, 0, 1); 
  public get startDate() {
    return this._startDate;
  }
  public set startDate(value) {
    this._startDate = value;
  }

  data = {
    courstitle :"Enter text"
  };

  onLogoClicked(){
    alert('hello world');
  }

  onkeyUp(newTitle:string)
  {
    this.data.courstitle=newTitle;
    //console.log(newTitle.key);
    //this.data.courstitle+=newTitle.key;
  }




  


  @Input()
  EntityName : string;

   //title : string;
     [x: string]: any;
   title: string = 'project';
      constructor(@Inject(MyserviceService) myserviceService) 
   {
   console.log(myserviceService);
   console.log("this is component");
  }

  
 
    //@HostListener('click', ['$event'])
   //  onHostClick(event: Event): void
 //{
  //      alert("hello world")
  //}
 value = 0;

 
 @HostListener('window:keyup', ['$event'])
 keyEvent(event: KeyboardEvent) {
  console.log(event);
   
   if (event.keyCode === KEY_CODE.RIGHT_ARROW) {
    this.increment();
  }

 if (event.keyCode === KEY_CODE.LEFT_ARROW) {
    this.decrement();
  }
 }
 
 increment() {
  this.value++;
 }
 
 decrement() {
  this.value--;
   }
}




