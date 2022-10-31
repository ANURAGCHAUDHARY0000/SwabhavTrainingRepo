import Bank,{sayHello} from './bankModule'   // it's the way to import default class

let b = new Bank("hdfc","mumbai")
console.log(b);
console.log(sayHello("sachin"));