function matrixOfNumbers(args) {
    let rowsAndCols = +args[0],
        result = ' ',
        i,
        j;
		
    for (i = 0; i < rowsAndCols; i += 1) {
        for (j = i + 1; j <= rowsAndCols + i; j += 1) {
            result += j + ' ';
        }

        result += '\n';
    }

    console.log(result);
}
matrixOfNumbers(['3']);