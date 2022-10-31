//wrap a set of variables and functions together in a single scope.
function EmployeeDetails() {
    var name = "Anurag";
    var age = 30;
    var designation = "Developer"
    var salary = 10000;

    var calculateBonus = function(amount) {
      salary = salary + amount;
    }
  
    
    return {
      name: name,
      age: age,
      designation: designation,
      calculateBonus: calculateBonus
    }
  }
  
  var newEmployee = EmployeeDetails()
  var userName = newEmployee.name;
  console.log(userName);
  var userAge = newEmployee.age;
  console.log(userAge);
  var userDesignation = newEmployee.designation;
  console.log(userDesignation);

  var userBonus = newEmployee.calculateBonus(1000);
  console.log(userBonus);
 // var salary = newEmployee.salary;
  //console.log(salary);
