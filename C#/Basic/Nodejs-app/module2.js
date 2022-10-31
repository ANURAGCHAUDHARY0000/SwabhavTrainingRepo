//no state

function dataService(){
    //object
    var service ={}

    console.log("module loaded");

    service.doTask1 = function(){
        console.log("do task1");
     }

     service.doTask2 = function(){
        console.log("do task2");
     }

     service.getData = function(){
        return Math.random() * 10;
     }

     return service;
}

dataService().doTask1();
dataService().doTask2();
console.log(dataService().getData());