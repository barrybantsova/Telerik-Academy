'use strict';
function solve (args){
var width = +(args[0]),
        height = +(args[1]);
 var area = width * height;
 var perimeter = 2 * ( width + height);
 console.log(parseFloat(area).toFixed(2) + ' '+ parseFloat(perimeter).toFixed(2));
}
