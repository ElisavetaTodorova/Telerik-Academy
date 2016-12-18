function solve(params) {
    var n = +params[0];
    var array = params[1].split(' ').map(Number);

    function largerThanNeighboursCount(array) {
        var count = 0;

        for (var i = 1; i < array.length - 1; i += 1) {

            if(array [i] > array[i - 1] && array[i] > array[i + 1]){
                count += 1;
            }
        }

        return count;
    }

    console.log(largerThanNeighboursCount(array));

}

var input = [
    '6',
    '-26 -25 -28 31 2 27'
];

solve(input);