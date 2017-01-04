
function exchangeIfGreater(args){
    let firstNum = +args[0];
    let secondNum = +args[1];
    let temp = firstNum;

    if(firstNum > secondNum){
        firstNum = secondNum;
        secondNum = temp;
        console.log(firstNum + ' ' + secondNum);
    }else{
        console.log(firstNum + ' ' + secondNum);
    }
}
