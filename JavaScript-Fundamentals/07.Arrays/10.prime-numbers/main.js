function solve(params) {
    var number = +params[0];


    for (j = number; j > 0; j -= 1) {
        var sqrt = Math.sqrt(j);
        var isPrime = true;

        for (var i = 2; i <= sqrt; i += 1) {
            if (j % i === 0) {
                isPrime = false;
                break;
            }
        }

        if(isPrime){
            console.log(j);
            return;
        }

    }
}

solve(['26']);