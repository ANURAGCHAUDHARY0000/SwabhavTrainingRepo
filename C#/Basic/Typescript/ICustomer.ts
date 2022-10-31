interface ICustomer{
    id : number,
    firstName :string,
    lastName :string,
    location? :string
}

printDetails([{id : 101,firstName : "Ram",lastName : "Kumar"},
{id : 102, firstName : "Shyam",lastName : "lal"}])

function printDetails(customers : Array<ICustomer>){
    for(let c of customers){
        console.log("FirstName " + c.firstName +"\nLastName " + c.lastName + "\nID " + c.id);
        console.log("-------------------------------");
    }
}