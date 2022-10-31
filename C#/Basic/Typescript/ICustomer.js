printDetails([{ id: 101, firstName: "Ram", lastName: "Kumar" },
    { id: 102, firstName: "Shyam", lastName: "lal" }]);
function printDetails(customers) {
    for (var _i = 0, customers_1 = customers; _i < customers_1.length; _i++) {
        var c = customers_1[_i];
        console.log("FirstName " + c.firstName + "\nLastName " + c.lastName + "\nID " + c.id);
        console.log("-------------------------------");
    }
}
