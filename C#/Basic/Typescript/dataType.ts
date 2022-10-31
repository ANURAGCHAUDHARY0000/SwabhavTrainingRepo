let userName : string;
let cgpa : number;
let isMale : boolean;
let displayText : string;

userName="Ram";
cgpa= 10;
isMale=true;

displayText = `================================
Showing Details           
===============================
user is : ${userName}
cgpa is : ${cgpa}
isMale  : ${isMale?"Male":"Female"}` 

console.log(displayText);


