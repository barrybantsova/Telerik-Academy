function theBiggestOf3(args){
    let a = +args[0],
        b = +args[1];
        c = +args[2];
    let temp1 = Math.max(a,b);
    let temp2 = Math.max(temp1, c);

    if(temp1 > temp2){
        console.log(temp1);
    }else{
        console.log(temp2);
    }

}
theBiggestOf3(['5', '2', '2']);