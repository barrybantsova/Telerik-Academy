'use strict';
function mmsa(args){
    let min = +args[0],
        max = +args[0],
        sum = 0,
        average = 0,
        length = args.length,
        i;

    for(i = 0; i < length; i += 1) {
        if (min > +args[i]) {
            min = +args[i];
        }

        if (max < +args[i]) {
            max = +args[i];
        }

        sum += +args[i];
    }

    average = sum / length;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + average.toFixed(2));
}
mmsa(['2', '5', '1']);