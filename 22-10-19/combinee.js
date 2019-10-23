"use strict";
exports.__esModule = true;
// RxJS v6+
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
// elem refs
var redTotal = document.getElementById('red-total');
var blackTotal = document.getElementById('black-total');
var total = document.getElementById('total');
var addOneClick$ = function (id) {
    return rxjs_1.fromEvent(document.getElementById(id), 'click').pipe(
    // map every click to 1
    operators_1.mapTo(1), 
    // keep a running total
    operators_1.scan(function (acc, curr) { return acc + curr; }, 0), operators_1.startWith(0));
};
rxjs_1.combineLatest(addOneClick$('red'), addOneClick$('black')).subscribe(function (_a) {
    var red = _a[0], black = _a[1];
    redTotal.innerHTML = red;
    blackTotal.innerHTML = black;
    total.innerHTML = red + black;
});
