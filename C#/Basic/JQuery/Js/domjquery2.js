$(document).click(function(){
    var msg = " ";
    for(var i =1;i<=6;i++)
    {
        msg += "<h"+i+">Welcome to jQuery</h" + i + ">";
    }
          $("#Container").html(msg).css('color' , 'red').fadeToggle(msg);
                        
         
});