function solve(params) {
    var n = +params[0];

    var array = [];

    for (var i = 0; i < n; i++) {
        array[i] = i * n;
    }

    console.log(array.join('\r\n'));
}

solve(['5']);