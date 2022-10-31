var sno = 0;
var table = document.querySelector('table');
const func = fetch("").then((response) => {
   
    return response.json();
    }).then((data) => {
    data.forEach(e => {
        if(e.rollNo!=0 && e.name!=null ){
        sno++;
        table.innerHTML+=` ${sno} + ${e.age} + ${e.rollNo} + ${e.name} +  ${e.email} + ${e.date} + ${e.isMale}`;
        console.log(table);
        
        }
    });
  
});



