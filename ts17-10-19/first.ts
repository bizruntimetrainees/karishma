function addNumbers(a: number, b: number,c:number=0,d:number=0):number { 
  return a + b+c+d; 
} 
var sum: number = addNumbers(10,15,3) 
console.log('Sum of the two numbers is: ' +sum);