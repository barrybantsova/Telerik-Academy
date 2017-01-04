function theBiggestOf5Nums(args){
    let first = +args[0],
        second = +args[1],
        third = +args[2],
        fourth = +args[3],
        fifth = +args[4];

    let array = [first, second, third, fourth, fifth];
    let biggest = Number.MIN_SAFE_INTEGER;
    for (let i = 0; i < array.length; i++) {
        if (biggest < array[i]) {
            biggest = array[i];
        }
    }

    console.log(biggest);

}
theBiggestOf5Nums(['5', '2', '2', '4', '1']);
