function solve(args) {
    var number = +[args],
        position = 3;

    console.log((number >> position) & 1);
}