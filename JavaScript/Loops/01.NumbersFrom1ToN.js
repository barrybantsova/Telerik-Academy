function numbersFrom1ToN(args) {
    const n = +args[0];
    let result = '';

    for(let i = 1; i <= n; i+=1){
        result += i + ' ';
    }
    console.log(result);
}
numbersFrom1ToN(['5']);