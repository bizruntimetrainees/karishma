import { BehaviorSubject } from "rxjs";


const s = new BehaviorSubject<number>(0);


s.subscribe(
  next => console.log("before:", next),
  error => console.warn(error),
  () => console.log("complete before")
);


s.next(1);
s.next(2);
s.next(3);
// s.complete();

/* Subscribe late to subject. */
s.subscribe(
  next => console.log("after:", next),
  error => console.warn(error),
  () => console.log("complete after")
);