class StudentV4{
    constructor(private name = "",private cgpa = 0){

    }

    getUserName() {
        return this.name;
    }

    setUserName(pname : string){
        this.name = pname;
    }

    get details(){
        return `name is ${this.getUserName}  and cgpa is ${this.cgpa}`
    }
}

let s4 = new StudentV4("abc");
console.log(s4.getUserName);
s4.setUserName ("lmno");
console.log(s4.details);