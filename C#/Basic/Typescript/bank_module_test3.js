"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var bm = require("./bankModule"); //* import everything
var b = new bm.default("yes", "pune");
var c = new bm.Customer("abc");
var a = new bm.Account(1000);
console.log(a);
console.log(b);
console.log(c);
