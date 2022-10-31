//synchronous

var DataService = function(){
    var service = {};

    service.getData =  function(){
        var no = Math.random() * 10;
        if(no > 5)
         return no;
         else
         {
            throw "result was less than five :" + no;
        }
    }
    return service;
}();

try{
    var result = DataService.getData()
    console.log(result);
}catch(err){
    console.log(err);
}

console.log("end of script");