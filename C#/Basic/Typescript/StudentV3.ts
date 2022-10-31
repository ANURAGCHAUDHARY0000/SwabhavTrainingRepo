class StudentV3{

    constructor(private name : string, private cgpa : number){
       
    }
    getUserName() : string{
        return this.name;
    }

    setUserName(pname : string){
        this.name = pname;
    }
    
    getUserCgpa() : number{
        return this.cgpa;
    }

    setUserCgpa(pcpg : number){
        this.cgpa = pcpg;
    }
}
    var s3 = new StudentV3("sachin",8);
    console.log(s3);
    s3.setUserName("ram");
    s3.setUserCgpa(10);
    console.log(s3.getUserName);
