interface IMessage{
    message : string
}

function MyNeedToRefactor(msg:IMessage){
    return function(cls:Function){
        console.log(cls);
        console.log(cls.name);
        console.log(msg.message);
    }
}

@MyNeedToRefactor({message : "urgent"})
class MyClass1{
    constructor(public description = "MyClass"){}
}

@MyNeedToRefactor({message : "low urgency"})
class MyClass2 {
    constructor(public description = "MyClass"){}
}

