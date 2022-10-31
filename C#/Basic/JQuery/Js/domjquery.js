console.log($);
console.log(typeof($));
console.log(window.$ == window.jquery);
$(document).ready(function(){
    var msg = " ";
    for(var i =1;i<=6;i++)
    {
        msg += "<h"+i+">Welcome to jQuery</h" + i + ">";
    }
          $("#Container").html(msg)
                        .fadeOut(msg);
         
})
