function quadraticEquation(args){
    //ax^2 + bx + c = 0
    let a = +args[0],
        b = +args[1],
        c = +args[2];
    let x1,x2;

        const discriminant = Math.pow(b,2) - 4 * a * c;

        if(discriminant === 0){
            x1 = x2 =(-b/(2 * a)).toFixed(2);
            console.log('x1=x2=' + x1);
        }
        else if(discriminant < 0){
            console.log('no real roots');
        }
        else if( discriminant > 0){
            x1 = ((-b - Math.sqrt(discriminant))/ (2 * a)).toFixed(2);
              x2 = ((-b + Math.sqrt(discriminant))/ (2 * a)).toFixed(2);
              console.log('x1='+ x1 + ';'+ ' '+ 'x2='+ x2);
        }

}
quadraticEquation(['0.2', '9.572', '0.2']);