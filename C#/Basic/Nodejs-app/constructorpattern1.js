function Student(name , cgpa){
    console.log(typeof this);
    console.log(this == window);
    this.name = name;
    this.cgpa = cgpa;

    this.getDetails = function() {
        return "name is " +this.name+ " cgpa is : "+this.cgpa;
    }
}

var s1 = new Student("Ram",9);
console.log(s1);
console.log(s1.getDetails());
s1.cgpa = 7;
console.log(s1.getDetails());

var s2 = Student("shyam",10);  //this == window
//console.log(s2);
//console.log(s2.getDetails());

