var slider = document.querySelector('#slider');
var message = document.querySelector('#msg');
var container = document.querySelector('#btncontainer');  
var attempts = 0;
var randomNumber ;
var winner = false;
slider.addEventListener('input',function(e){
    container.innerHTML = "";
    slider.value = e.target.value ;
    message.innerHTML = slider.value;
  
for(let i =1; i<= slider.value; i++)
{
    const buttons = document.createElement("button");
    randomNumber = Math.floor(1 + Math.random() * slider.value);
    buttons.innerHTML = i;
    buttons.setAttribute('onclick','Click(event)')
    buttons.style =  "border-radius: 50% ; background-color: gray;"
    container.appendChild(buttons);
}
})
 
function Click(e)
{  
    console.log(randomNumber); 
        // console.log(e.target.innerHTML);
    if(attempts < 3)
    {  
    attempts ++;      
    var actualValue = e.target.innerHTML;
    document.querySelector("#msg1").innerHTML = `You Clicked On ${actualValue}`;
   
    if(actualValue == randomNumber)
    {
       e.target.style = "border-radius: 50% ; background-color: blue;"
       winner = true;
      document.getElementById("msg4").innerHTML = "You won the game";
      document.getElementById("msg7").innerHTML = "";
            
    }
    else if(actualValue < randomNumber)
    {
        e.target.style = "border-radius: 50% ; background-color: red ;"
        document.getElementById("msg7").innerHTML = "Please Select Higher";
       
    }
    else if(actualValue > randomNumber)
    {
       e.target.style = "border-radius: 50% ; background-color: green ;"
       document.getElementById("msg7").innerHTML = "Please Select Lower";
      
    }
    document.getElementById("msg6").innerHTML = "Total Attempts : 3 " + " Remaining Attempts " +`${3-attempts}`;
   }

     if(winner == false && attempts == 3)
    {
        document.getElementById("msg3").innerHTML = "Your Attempts expire you loose the game";
        document.getElementById("msg2").innerHTML = "Random Value Is" +  `${randomNumber}`;
        document.getElementById("msg7").innerHTML = "";
   }
   
    }