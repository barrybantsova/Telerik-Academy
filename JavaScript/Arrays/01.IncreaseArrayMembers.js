function increaseArrayMembers(args){
    let n = +args[0],
        array = [];

        for(let i = 0; i < n; i+=1){
            array[i] = i * 5;
            console.log(array[i]);
        }
}
increaseArrayMembers(['5']);