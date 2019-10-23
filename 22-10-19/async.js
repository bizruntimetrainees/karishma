"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var s = new rxjs_1.AsyncSubject();
s.subscribe(function (next) { return console.log('before:', next); }, function (error) { return console.warn(error); }, function () { return console.log('complete before'); });
s.next(1);
s.next(2);
s.next(3);
/* Subscribe late to subject. */
s.subscribe(function (next) { return console.log('after:', next); }, function (error) { return console.warn(error); }, function () { return console.log('complete after'); });
s.complete();
