import * as bm from './bankModule'  //* import everything

let b = new bm.default("yes","pune");
let c = new bm.Customer("abc");
let a = new bm.Account(1000);

console.log(a);
console.log(b);
console.log(c);