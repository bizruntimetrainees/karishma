"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var a = new rxjs_1.Observable(function (observer) {
    observer.next(1);
    throw "Error!";
    setTimeout(function () { return observer.complete(); }, 4000);
});
a.pipe(retry(3))
    .subscribe(function (result) { return console.log(result); }, function (err) { return console.log("Error"); });
