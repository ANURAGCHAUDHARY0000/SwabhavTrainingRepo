$(document).ready(function () {
    $('p').click(function () {
        console.log('you clicked on p',this);
    });

 //selector in jquery
//element selector
//id selector
//class selector

//element selector
// $('p').click();

//id selector
//  $('#First').click();

//class selector
//   $('.odd').click();

//other selector
$('*').click() // clicks on all elements
});


