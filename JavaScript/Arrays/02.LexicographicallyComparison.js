'use strict';
function lexicographicallyComparison(args) {
    let firstArray = args[0].split(''),
        secondArray = args[1].split('');

    if(firstArray > secondArray){
        console.log('>');
    }
    else if( firstArray < secondArray){
        console.log('<');
    }
    else {
        console.log('=');
    }
}
lexicographicallyComparison(['hello', 'halo']);