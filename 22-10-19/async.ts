import { Observable } from 'rxjs';
     import { AsyncSubject } from "rxjs";



const s = new AsyncSubject<number>();


s.subscribe(
  next => console.log('before:', next),
  error => console.warn(error),
  () => console.log('complete before')
);


s.next(1);
s.next(2);
s.next(3);

/* Subscribe late to subject. */
s.subscribe(
  next => console.log('after:', next),
  error => console.warn(error),
  () => console.log('complete after')
);



s.complete();