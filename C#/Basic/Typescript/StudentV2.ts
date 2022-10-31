class StudentV2{
    

    constructor(public name : string, public cgpa : number){
       
    }
}

let s2 = new StudentV2("Ram",10);
console.log("Name " + s2.name + "\nCGPA " + s2.cgpa);

s2.name = "Krishna";
s2.cgpa = 10;
console.log("Name " + s2.name + "\nCGPA " + s2.cgpa);