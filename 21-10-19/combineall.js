"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var timerOne$ = rxjs_1.timer(1000, 4000);
var timerTwo$ = rxjs_1.timer(2000, 4000);
var timerThree$ = rxjs_1.timer(3000, 4000);
rxjs_1.combineLatest(timerOne$, timerTwo$, timerThree$, 
// combineLatest also takes an optional projection function
function (one, two, three) {
    return "Timer One (Proj) Latest: " + one + ", \n              Timer Two (Proj) Latest: " + two + ", \n              Timer Three (Proj) Latest: " + three;
}).subscribe(console.log);
