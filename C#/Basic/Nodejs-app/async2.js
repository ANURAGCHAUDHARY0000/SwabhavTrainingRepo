//synchronous

var DataService = function(){
    var service = {};

    service.getData =  function(onSuccess,onError){
        var no = Math.random() * 10;
        if(no > 5)
         onSuccess({message:"success",data : no});
         else
         {
            onError({message:"error",details : "Data was too low" + no});
        }
    }
    return service;
}();

 DataService.getData(onSuccess,onError)  // Call back function
 
 function onSuccess(response){
    console.log("onsuccess" + response.message + response.data);
 }

 function onError(response){
    console.log("on error" + response.message + response.details);
 }   

DataService.getData((resp) => {
    console.log("inside lamda success "+ resp.message + resp.data);
},(errResp) => {
    console.log("inside lamda error " + errResp.message + errResp.details );
});
console.log("end of script");