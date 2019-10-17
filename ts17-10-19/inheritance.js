var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Person = /** @class */ (function () {
    function Person() {
    }
    Person.prototype.getFullName = function () {
        return this.firstName + " " + this.lastName;
    };
    Person.prototype.greet = function () {
        console.log("hello ");
    };
    return Person;
}());
var Programer = /** @class */ (function (_super) {
    __extends(Programer, _super);
    function Programer() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Programer.prototype.greet = function () {
        console.log("hello World ");
    };
    Programer.prototype.greetPerson = function () {
        _super.prototype.greet.call(this);
        _super.prototype.getFullName.call(this);
    };
    return Programer;
}(Person));
var aProgramer = new Programer();
aProgramer.lastName = "scott";
aProgramer.firstName = "shaik";
aProgramer.greetPerson();
aProgramer.greet();
console.log(aProgramer.getFullName());
