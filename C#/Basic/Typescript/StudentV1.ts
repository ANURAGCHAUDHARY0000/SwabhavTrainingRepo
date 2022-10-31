class StudentV1{
    name : string
    cgpa : number

    constructor(pname,pcgpa){
        this.name = pname;
        this.cgpa = pcgpa;
    }
}

let s1 = new StudentV1("Ram",10);
console.log("Name " + s1.name + "\nCGPA " + s1.cgpa);

s1.name = "Krishna";
s1.cgpa = 10;
console.log("Name " + s1.name + "\nCGPA " + s1.cgpa);