var customers = [{id: 101,name: "Anurag",location:"mumbai"},
{id: 102,name: "Ram",location:"mumbai"},
{id: 103,name: "Shyam",location:"mumbai"},
{id: 104,name: "Mohan",location:"pune"}];

var mumbai_customers = customers.filter((c)=> c.location.toLowerCase()=="mumbai");
mumbai_customers.push({id: 105,name: "Ravi",location:"mumbai"});
mumbai_customers.forEach((c)=> console.log(c));

var btn = document.querySelector("#load");
var btn2 = document.querySelector("#load2");
var c_id = document.querySelector("#id");
var c_name = document.querySelector("#name");
var c_location = document.querySelector("#location");
var add_customer = document.querySelector("#addCustomer");
var msg = document.querySelector("#msg");
var form = document.querySelector("#myform");
var container = document.querySelector("#container");
var mumbai_container = document.querySelector("#mumbai_container");


add_customer.addEventListener("click",()=>{
    if(c_id.value.length == 0 && c_name.value.length == 0 && c_location.value.length == 0)
    {
        msg.innerHTML = "Please fill all details!!"
    }
    else{
    customers.push({id: c_id.value,name: c_name.value,location: c_location.value});
    msg.innerHTML = "Customer added successfully!!";
    }
    form.reset();
})


btn.addEventListener("click",()=> {
   let container1 = ``;
    customers.forEach(c=>{
        container1 += `<li>${c.name},${c.id},${c.location}</li>`;
    });
    container.innerHTML = container1;
});
btn2.addEventListener("click",()=>{
    var table = loadTable(customers);
    mumbai_container.innerHTML = table;
})


function getCustomerRow(c){
    return `<tr>
                <td> ${c.id}</td>
                <td> ${c.name}</td>
                <td> ${c.location}</td>
            </tr>`
}


function loadTable(customer){
var table = `
<table>
    <thead>
        <tr>
            <th colspan = "1">Id</th>
            <th colspan = "1">Name</th>
            <th colspan = "1">Location</th>
        </tr>
    </thead>
    <tbody>
        ${customer.map((c) => getCustomerRow(c))}
    </tbody>
</table>`
return table;
}