function binarySearch(args) {
    args.splice(0, 1);
    let startSearch = 0,
        endSearch = args.length - 1,
        middle,
        searchedNumber = args.splice(-1, 1);

        while (startSearch <= endSearch)
        {
            middle = parseInt((startSearch + endSearch) / 2);
            if (args[middle] == searchedNumber)
            {
                console.log(middle);
                break;
            }
            else if (args[middle] < searchedNumber)
            {
                startSearch = middle + 1;
            }
            else if (args[middle] > searchedNumber)
            {
                endSearch = middle - 1;
            }
        }

}
binarySearch(['10', '1', '2', '4', '8', '16', '31', '32', '64', '77', '99', '32']);