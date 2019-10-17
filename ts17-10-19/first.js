function addNumbers(a, b, c, d) {
    if (c === void 0) { c = 0; }
    if (d === void 0) { d = 0; }
    return a + b + c + d;
}
var sum = addNumbers(10, 15, 3);
console.log('Sum of the two numbers is: ' + sum);
