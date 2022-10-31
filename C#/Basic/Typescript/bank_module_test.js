"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var bankModule_1 = require("./bankModule");
var b = new Bank("icici", "Andheri");
console.log(b);
var c = new bankModule_1.Customer("Ram");
console.log(c);
var a = new bankModule_1.Account();
console.log(a);
