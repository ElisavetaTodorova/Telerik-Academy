function solve(params) {
    var a = +params[0];
    var b = +params[1];
    var h = +params[2];

    var area = ((a + b) / 2) * h;

    console.log(area.toFixed(7));
}

solve(['0.222', '0.333', '0.555']);