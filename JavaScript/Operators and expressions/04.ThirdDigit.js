function solve(args){
var digit =+ args[0];
var isTheDigit7 = parseInt((digit %1000)/100);
if(isTheDigit7 === 7){
    console.log('true');
}else{
    console.log('false '+ isTheDigit7);
}
}