function  solve(args){
    let number = parseInt(args[0]);
    let remainder = Math.floor(number % 1000);
    let result = Math.floor(remainder / 100);

    if(result === 7){
        console.log('true');
    } else {
        console.log('false ' + result);
    }
}

solve(['8801']);