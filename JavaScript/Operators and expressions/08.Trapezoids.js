function trapezoidArea(args) {
    var a = +(args[0]),
        b = +(args[1]),
        h = +(args[2]);

    var area = (((a + b) / 2) * h).toFixed(7);
    
    console.log(area);
} 