// Constructor pattern

//there are 3 ways to create objects in js

//1st way

//var newObject = {}

//2nd way
//var newObject = Object.create(Object.prototype);

//3rd way
//var newObject = new Object();


//1.way
var newObject = {}
//set
newObject.someKey = "Hello"

//get 
var value = newObject.someKey;

console.log(newObject)
console.log(value)

//2nd way
//set
newObject["someKey"] = "Hi"
//get
var value = newObject["someKey"];
console.log(value);

//3rd way 
Object.defineProperties(newObject,{
    "someKey" :{
        value : "hlw",
        writable : true
    }
})

var value = newObject.someKey;

console.log(newObject)
console.log(value)

//constructor
function Car(model, year, miles) {
    this.model = model;
    this.year = year;
    this.miles = miles;

    this.toString = function(){
        return this.model + " has done " + this.miles + " miles ";
    }
    
}

var civic = new Car("Honda", 2009,200);
var range = new Car("RangeRover", 2004,100);

console.log(civic.toString());
console.log(range.toString());

