var StudentV1 = /** @class */ (function () {
    function StudentV1(pname, pcgpa) {
        this.name = pname;
        this.cgpa = pcgpa;
    }
    return StudentV1;
}());
var s1 = new StudentV1("Ram", 10);
console.log("Name " + s1.name + "\nCGPA " + s1.cgpa);
s1.name = "Krishna";
s1.cgpa = 10;
console.log("Name " + s1.name + "\nCGPA " + s1.cgpa);
