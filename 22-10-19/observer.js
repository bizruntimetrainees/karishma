"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var observable = new rxjs_1.Observable(function (observer) {
    var interval = setInterval(function () {
        observer.next('Hello from Observableland!');
    }, 1000);
    return function () {
        clearInterval(interval);
    };
});
observable.subscribe(function (value) { return console.log(value); });
