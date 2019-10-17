var Person = /** @class */ (function () {
    function Person() {
    }
    Person.prototype.getFullName = function () {
        return this.firstName + " " + this.lastName;
    };
    return Person;
}());
var aPerson = new Person();
aPerson.firstName = "karishma";
aPerson.lastName = "shaik";
console.log(aPerson.firstName);
console.log(aPerson.lastName);
console.log(aPerson.getFullName());
