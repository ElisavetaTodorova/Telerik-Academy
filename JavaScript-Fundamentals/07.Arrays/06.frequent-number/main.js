function solve(params) {
    var n = +params[0];

    var array = [];

    for (var i = 0; i < n; i += 1) {
        array.push(+params[1 + i]);
    }

    array.sort();

    var times= 0;
    var current = 1;
    var maxElement = 0;
    for (var j = 0; j < array.length - 1; j++) {
        if (array[j] == array[j + 1]) {
            current += 1;
        } else {
            if (times< current) {
                times= current;
                maxElement = array[j];
            }
            current = 1;
        }
    }

    console.log(maxElement + " (" + times + " times)");
}

solve(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3']);