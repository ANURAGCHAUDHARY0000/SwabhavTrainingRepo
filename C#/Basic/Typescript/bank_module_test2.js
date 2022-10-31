"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var bankModule_1 = require("./bankModule"); // it's the way to import default class
var b = new bankModule_1.default("hdfc", "mumbai");
console.log(b);
console.log((0, bankModule_1.sayHello)("sachin"));
