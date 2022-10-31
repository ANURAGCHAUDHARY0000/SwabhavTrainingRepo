export default class Bank{
    constructor(public name:string, public location:string){

    }
}

export class Account{
    constructor(public balance = 500){

    }
}

export class Customer{
    constructor(public userName : string){
        
    }
}

export function sayHello(name:string){
    return "Hello says " + name
}