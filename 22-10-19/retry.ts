import { Observable } from 'rxjs';

let a = new Observable(observer => {
 observer.next(1);
 throw "Error!";
 setTimeout(() => observer.complete(), 4000);
});
a.pipe(retry(3))
 .subscribe(
 result => console.log(result),
 err => console.log("Error")
 );
