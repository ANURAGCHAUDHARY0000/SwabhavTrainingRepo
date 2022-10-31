var DataService = function(){
    var service = {};
    service.getData = function(){
        return new Promise(function(resolve,reject){
            console.log("inside Promise");
            if(no > 5)
            resolve({message:"success",data : no});
            else
            {
               reject({message:"error",details : "Data was too low" + no});
           }
        });

    }
    return service;
}();

DataService.getData()
           .then(function(resp){
            console.log(resp)
            return resp.message;
           })
           .then(function(msg){
            console.log("message from chained call");
            console.log(msg);
           })
           .catch(function(errResp){
            console.log(errResp)
           })
           console.log("end of script");


            