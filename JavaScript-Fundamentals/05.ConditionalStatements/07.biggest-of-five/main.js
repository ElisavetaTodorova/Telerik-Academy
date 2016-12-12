function solve(params) {
    let a = +params[0];
    let b = +params[1];
    let c = +params[2];
    let d = +params[3];
    let e = +params[4];

    let max = Math.max(a, b, c, d, e);

    console.log(max);
}

solve(['-2', '-22', '1', '0', '0']);