import { Observable, asyncScheduler } from 'rxjs';
import { observeOn } from 'rxjs/operators/index';
 
var observable = new Observable((proxyObserver) => {
  proxyObserver.next(1);
  proxyObserver.next(2);
  proxyObserver.next(3);
  proxyObserver.complete();
}).pipe(
  observeOn(asyncScheduler)
);
 
var finalObserver = {
  next(x) {
    console.log('got value ' + x)
  },
  error(err) {
    console.error('something wrong occurred: ' + err);
  },
  complete() {
     console.log('done');
  }
};
 
console.log('just before subscribe');
observable.subscribe(finalObserver);
console.log('just after subscribe');
const proxyObserver = {
    next(val) {
      asyncScheduler.schedule(
        (x) => finalObserver.next(x),
        0 /* delay */,
        val /* will be the x for the function above */
      );
    },
  
    //...
  }