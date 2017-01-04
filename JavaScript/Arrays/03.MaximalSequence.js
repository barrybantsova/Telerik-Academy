'use strict';
function maximalSequence(args) {
    args.splice(0, 1);
    let count = 1;
    let maxCount = 0;

    for (let index = 1; index < args.length; index++) {
        if (args[index] === args[index - 1]) {
            count++;
            if (maxCount < count) {
                maxCount = count;
            }
        }
        else {
            count = 1;
        }
    }
    console.log(maxCount);
}
maximalSequence(['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '1']);