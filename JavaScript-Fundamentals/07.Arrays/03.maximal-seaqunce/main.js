function solve(params) {
    var n = +params[0];

    var array = [];

    for (var i = 0; i < n; i += 1) {
        array.push(+params[1 + i]);
    }

    var max = 0;
    var current = 1;
    for (var j = 0; j < array.length - 1; j++) {
        if(array[j] == array[j + 1]){
            current += 1;
        }else {
            max = Math.max(current, max);
            current = 1;
        }
    }

    console.log(max);
}

solve(['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '1']);