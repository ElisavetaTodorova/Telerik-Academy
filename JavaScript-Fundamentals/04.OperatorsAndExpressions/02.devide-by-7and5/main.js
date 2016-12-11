function solve(args) {
    let number = + args[0];

    if(number % 5 === 0 && number % 7 === 0) {
        console.log('true ' + number);
    } else {
          console.log('false ' + number);
    }
}

solve(['5']);
solve(['35']);
solve(['7']);
solve(['0']);