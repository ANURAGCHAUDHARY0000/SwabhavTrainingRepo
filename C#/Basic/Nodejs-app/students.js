    var add = document.querySelector("#addStudent");
    var btn = document.querySelector("#container");
    var id = Date.now();
    var table1 = document.querySelector("#table")
    var students = [];

    if(localStorage[`aurionpro.students`]){
        students = JSON.parse(localStorage[`aurionpro.students`])
        renderTable();
    }

    add.addEventListener("click",() =>
    {
        var firstName = document.querySelector("#fname").value;
        var lastName = document.querySelector("#lname").value;             
        var student = {};
        student.id = id;
        student.firstName = firstName;
        student.lastName = lastName;

        students.push(student)
        localStorage[`aurionpro.students`] = JSON.stringify(students);
        renderTable();
    })

   function renderTable(){
        var container1 = ``;   
        students.forEach(c=>{
         container1 +=  `<li>${c.id}, ${c.firstName}, ${c.lastName}</li>` 
      }); 
       container.innerHTML = container1;
       var table = loadTable(students);
       table1.innerHTML = table;
    }
    
    function loadTable(customer) {
        var table = `
<table>
<thead>
    <tr>
        <th colspan = "1">Id</th>
        <th colspan = "1">FirstName</th>
        <th colspan = "1">LastName</th>
    </tr>
</thead>
<tbody>
    ${customer.map(getStudentRow).join('')}
</tbody>
</table>`
        return table;
    }
    function getStudentRow(c) {
        return `<tr>
            <td> ${c.id}</td>
            <td> ${c.firstName}</td>
            <td> ${c.lastName}</td>
        </tr>`
    }
