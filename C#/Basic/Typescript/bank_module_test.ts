import{Customer,Account} from './bankModule'  // it's the way to import non default classes
import Bank from './bankModule'  //it's the way to import default class

let b = new Bank("icici","Andheri");
console.log(b);

let c = new Customer("Ram")
console.log(c)

let a = new Account();
console.log(a)

