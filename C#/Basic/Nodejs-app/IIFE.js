// IIFE Immediately Invoking Function Expression
f1(); // function statement is hoisted
function f1()
{
    console.log("Inside a function");
}

//f2();  //can not be hoisted as function.
var f2 = function(){
    console.log("inside f2");
}

f2();  // after function declaration it can be hoisted

var f3 = function(){
    console.log("inside f3");
}();

console.log(typeof f3);  //undefined

(function f4(){
    console.log("inside f4");
}());

(function f5(){
    console.log("inside f5");
})();