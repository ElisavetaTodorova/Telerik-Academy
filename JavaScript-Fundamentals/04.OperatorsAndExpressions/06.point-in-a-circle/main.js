function solve(params) {
    let x = +params[0];
    let y = +params[1];

    let c = Math.sqrt((x * x) + (y * y));

    if (c <= 2) {
        console.log('yes ' + c.toFixed(2));
    } else {
        console.log('no ' + c.toFixed(2));
    }

}

solve(['-1', '2']);