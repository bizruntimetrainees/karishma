import { of, concat } from 'rxjs';

concat(
    of(4, 5, 6),
    of(7, 8, 9),
  of(1, 2, 3)
  

)
  
  .subscribe(console.log);