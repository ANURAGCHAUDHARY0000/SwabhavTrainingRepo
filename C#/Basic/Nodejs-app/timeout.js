//Asynchronous --> two process are working simultaneously
console.log("start");
//setTimeout(printHello,5*1000);
//setTimeout(printName("Krishna"),3*1000);
setTimeout(printHello());
setTimeout(printName("ram"));
function printHello(){
    console.log("hello 5 seconds over");
}

function printName(name){
    console.log("Hello Mr "+ name);
}

console.log("end of script");

setTimeout(function() {
        setTimeout(function() {
      printName("ram") //runs second after 3000ms
    },3*1000)
  
    printHello() //runs first, after 5000ms
  },5*1000)