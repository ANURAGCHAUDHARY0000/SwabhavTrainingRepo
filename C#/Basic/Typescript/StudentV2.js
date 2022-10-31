var StudentV2 = /** @class */ (function () {
    function StudentV2(name, cgpa) {
        this.name = name;
        this.cgpa = cgpa;
    }
    return StudentV2;
}());
var s2 = new StudentV2("Ram", 10);
console.log("Name " + s2.name + "\nCGPA " + s2.cgpa);
s2.name = "Krishna";
s2.cgpa = 10;
console.log("Name " + s2.name + "\nCGPA " + s2.cgpa);
