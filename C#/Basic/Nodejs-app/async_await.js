async function foo(){
    console.log("inside foo");
    return 10;
}

function bar(){
    return new Promise((resolve,reject) =>{
        console.log("inside bar")
        resolve(20);
    });
}

foo().then(r => console.log(r));
bar().then(r => console.log(r));

async function main(){
    console.log("inside main");
    var r1 = await foo(); //foo().then(r=>{})
    console.log("foo result is "+r1);

    var r2 = await bar();
    console.log("bar result is " + r2);

    console.log("end of main");
}
    main();
    console.log("end of script");
