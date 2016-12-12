function solve(params) {
    var a = +params[0];
    var b = +params[1];
    var c = +params[2];

    var max = Math.max(a ,b, c);

    console.log(max);
}

solve(['-0.1', '-0.5', '-1.1']);