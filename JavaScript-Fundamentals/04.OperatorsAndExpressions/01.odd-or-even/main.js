function solve(args) {
    let number = +args[0];

    if(number % 2 === 0){
        console.log('even ' + number)
    } else {
         console.log('odd ' + number)
    }
}

solve(['2']);
solve(['3']);
solve(['-1']);
solve(['20']);



