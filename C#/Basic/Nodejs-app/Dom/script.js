/*DOM*/
/* getelementbyid  */

var headerTitle = document.getElementById(`header-title`);
/* console.log(headerTitle);  */
/*headerTitle.textContent = `Computer Courses`; */
/* headerTitle.innerText = `Pro Courses`; */
/* headerTitle.innerHTML = `<h1>Hello<h1>`; 
var header = document.getElementById('header');
header.style.borderBottom = `10px solid #000` */

/* getelementbyclassname*/

var items = document.getElementsByClassName('list-item');
/*console.log(items[1]); */
items[1].textContent = 'Animation';
/*items[2].style.fontWeight = 'bold';*/
/*items[3].style.color = 'red';*/
/*items[2].style.backgroundColor = 'yellow'; */


/*getElementsByTagName */

var li = document.getElementsByTagName('li');
li[1].textContent = 'Animation';
/*li[2].style.fontWeight = 'bold';*/
/*li[3].style.color = 'red';*/
/*li[2].style.backgroundColor = 'yellow'; */


/* querySelector() */

/*id --> #
class --> . */
var headline = document.querySelector('#tagline');
 headline.style.color = 'yellow'; 

var items = document.querySelector('.list-item');
/*items.style.color = 'red';*/
/* queryselector work on first element 
items[2]style.color = 'red';
this will not work on 2nd element for doing this 
we need to use querselectorall*/

/* querySelectorAll() */

var items = document.querySelectorAll('.list-item');
/*items[2].style.color = 'red';*/

var input = document.querySelector('input');
input.value = 'Enter Your Name';

var button = document.querySelector('input[type = "submit"]');
button.style.backgroundColor = 'red';
button.style.color = 'yellow';
button.value = 'SEND';


