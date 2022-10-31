
var name_list = [];

function writeNamewithWishmessage()
{
   
    let wishMessage = document.getElementById('name').value;
    let name = wishMessage;
    name_list.push(wishMessage);
    display(name);

}

function display(name)
{

  //  let message = " ";
   // for(var i =0; i < name_list.length; i++)
    //{  
        // document.writeln("Hello ! Good Morning " + name_list[i]);
       //  wish = document.getElementById('wish').innerHTML =   "Hello ! Good Morning " + name_list[i];
       
       // message += wish ;
        //document.getElementById('wish').innerHTML  = message;

      //  var name = document.getElementById(`wish`).innerHTML;
        var list =  document.createElement("li")
        list.innerHTML =  "Hello ! Good Morning " + name;
        document.getElementById(`wish`).append(list);
        
    
   // }
}

function Clear()
{
    document.getElementById('wish').innerHTML = " ";
}

