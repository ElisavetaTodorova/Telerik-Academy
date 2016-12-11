function solve(params) {
    let number = +params[0];

    let sqrt = Math.sqrt(number);

    let isPrime = true;

    for (var i = 2; i <= sqrt; i += 1){
        if (number % i === 0) {
            isPrime = false;
        }
    }

    if (isPrime && number != 1 && number > 0) {
        console.log('true');
        
    } else {
        console.log('false');
    }
}
solve(['-3']);