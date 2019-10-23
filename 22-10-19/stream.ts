import { Observable } from 'rxjs';
     
    const observable = new Observable(subscriber => {
   const streamA$ = Rx.Observable.of(2);
    const streamB$ = Rx.Observable.of(4);
   const streamC$ = Rx.Observable.concat(streamA$, streamB$)
  .reduce((x, y) => x  + y);
streamC$.subscribe(console.log);
});