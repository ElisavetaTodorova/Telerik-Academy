function solve(params) {
    let a = +params[0];
    let b = +params[1];
    let c = +params[2];

    let product = a * b * c;

    if (product > 0) {
        console.log('+');
    } else if(product < 0){
        console.log('-');
    } else {
        console.log(0);
    }
}

solve(['-2', '-2', '1']);