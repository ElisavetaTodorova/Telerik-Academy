function solve(params) {
    var n = +params[0];

    var array = [];

    for (var i = 0; i < n; i += 1) {
        array.push(+params[1 + i]);
    }

    var searchdElemnt = +params[n + 1];

    var middle = array[n / 2];

    if (searchdElemnt < middle) {
        for (var j = 0; j < n / 2; j += 1) {
            if (searchdElemnt == array[j]) {
                console.log(j);
            }
        }
    } else if (searchdElemnt >= middle) {
        for (var k = n /2; k < n; k += 1) {
            if (searchdElemnt == array[k]) {
                console.log(k);
            }
        }
    } else {
        console.log(-1);
    }
}

solve(['10', '1', '2', '4', '8', '16', '31', '32', '64', '77', '99', '32']);