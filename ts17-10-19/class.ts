class Person
{
    firstName :string;
    lastName:string;
    getFullName()
    {
        return this.firstName+" "+this.lastName;
    }

}
var aPerson= new Person();
aPerson.firstName="karishma";
aPerson.lastName="shaik";
console.log(aPerson.firstName);
console.log(aPerson.lastName);
console.log(aPerson.getFullName());
