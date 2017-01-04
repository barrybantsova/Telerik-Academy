'use strict';
function maximalIncreasingSequence(args) {
    let array = args.map(Number),
        len = array.length,
        temp = 1,
        result = 1;

    for (let i = 2; i < len; i += 1) {
        if (array[i] > array[i - 1]) {
            temp += 1;
            if (temp > result) {
                result = temp;
            }
        } else {
            temp = 1;
        }
    }

    console.log(result);

}
maximalIncreasingSequence(['8', '7', '3', '2', '3', '4', '2', '2', '4']);