var userName;
var cgpa;
var isMale;
var displayText;
userName = "Ram";
cgpa = 10;
isMale = true;
displayText = "================================\nShowing Details           \n===============================\nuser is : ".concat(userName, "\ncgpa is : ").concat(cgpa, "\nisMale  : ").concat(isMale ? "Male" : "Female");
console.log(displayText);
