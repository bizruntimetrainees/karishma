 class Person
{
     firstName :string;
      lastName :string;
      
   
       getFullName()
   {
       return this.firstName+" "+this.lastName;
       
   }

greet()
{
        console.log("hello ");
    }
} 

 class Programer extends Person
{
 
    
    greet(){
        console.log("hello World ");
    }
    greetPerson()
    {
        super.greet()
        super.getFullName()
    }

}
var aProgramer =new Programer();

aProgramer.lastName="scott";
       aProgramer.firstName="shaik";


aProgramer.greetPerson();
aProgramer.greet();

console.log(aProgramer.getFullName());