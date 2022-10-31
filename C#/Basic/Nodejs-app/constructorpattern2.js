function Student(){
    var _name,_cgpa;

    this.setName = function(name){
        if(name.length >0)
        _name = name;
    }
    this.setCgpa = function(cgpa){
        _cgpa = cgpa;
    }

    this.getDetails = function(){
        this.getDetails = function() {
            return "name is " +this.name+ " cgpa is : "+this.cgpa;
        }
    }
}

var s1 = new Student()
console.log(s1);
s1.foo = "abc";
console.log(s1);
