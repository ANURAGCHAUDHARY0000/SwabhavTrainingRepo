function makeStudent(){
    var student = {}
    var _name = "";
    var _cgpa = 1;

    student.setName = function(name){
        if(name.length > 0)
        _name = name;
    }

    student.setCgpa = function(cgpa){
        if(cgpa >= 1 && cgpa <= 10)
        _cgpa = cgpa;
    }

    student.getDetails = function(){
        console.log( "name is :" +_name+ "cgpa is :" +_cgpa);
    }
      return student;

}
var s1 = makeStudent();
s1.setName("krishna");
s1.setCgpa(8);
console.log(s1);
console.log(s1.getDetails());





