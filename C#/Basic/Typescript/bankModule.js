"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.sayHello = exports.Customer = exports.Account = void 0;
var Bank = /** @class */ (function () {
    function Bank(name, location) {
        this.name = name;
        this.location = location;
    }
    return Bank;
}());
exports.default = Bank;
var Account = /** @class */ (function () {
    function Account(balance) {
        if (balance === void 0) { balance = 500; }
        this.balance = balance;
    }
    return Account;
}());
exports.Account = Account;
var Customer = /** @class */ (function () {
    function Customer(userName) {
        this.userName = userName;
    }
    return Customer;
}());
exports.Customer = Customer;
function sayHello(name) {
    return "Hello says " + name;
}
exports.sayHello = sayHello;
