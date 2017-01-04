// Vihicles

'use strict';

const S = 7;
let count =0;

for(let cars =0; cars * 4 <=S; cars += 1)
    for(let trucs =0; trucs *10 + cars *4<=S ; trucs+=1)
        for(let tricks =0; tricks * 3 +cars *4 +trucs *10 <= S ; trics +=1)
        if(cars * 4 + trucs * 10 + 3 * trics === S){
            count+=1;
        }

        console.log(count);
