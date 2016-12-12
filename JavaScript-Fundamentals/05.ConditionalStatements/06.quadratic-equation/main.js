function solve(params) {
    let a = +params[0];
    let b = +params[1];
    let c = +params[2];

    let d = b * b - (4 * a * c);

    if (d < 0) {
        console.log('no real roots');
    } else if (d === 0) {
        let x = -b / (2 * a);
        console.log(`x1=x2=${x.toFixed(2)}`);
    } else{
        let x1 = (-b + Math.sqrt(d)) / (2 * a);
        let x2 = (-b - Math.sqrt(d)) / (2 * a);

        let max = Math.max(x1, x2);
        let min = Math.min(x1, x2);

        console.log(`x1=${min.toFixed(2)}; x2=${max.toFixed(2)}`);
    }
}

solve(['2', '5', '-3']);