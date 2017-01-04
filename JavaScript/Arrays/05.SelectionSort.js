function selectionSort(args) {
    args.splice(0,1);
    let temp, 
    len = args.length;

    for (let i = 0; i < len; i++) {
        for (let j = i; j < args.length; j++) {
            if (+args[j] < +args[i]) {
                temp = +args[i];
                args[i] = +args[j];
                args[j] = temp;
            }

        }
        console.log(args[i]);
    }
}

selectionSort(['6', '3', '4', '1', '5', '2', '6']);