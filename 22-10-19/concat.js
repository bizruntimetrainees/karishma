"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
rxjs_1.concat(rxjs_1.of(4, 5, 6), rxjs_1.of(7, 8, 9), rxjs_1.of(1, 2, 3))
    .subscribe(console.log);
