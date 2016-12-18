function solve(params) {
    var n = +params[0];
    var array = params[1].split(' ').map(Number);
    var searchedNumber = +params[2];

    function appearanceCount(array, number) {
        var count = 0;

        for (var i = 0; i < array.length; i++) {
            if (array[i] === number) {
                count += 1;
            }

        }

        return count;
    }

    console.log(appearanceCount(array, searchedNumber));
}

var input = [
    '8',
    '28 6 21 6 -7856 73 73 -56',
    '73'
];

solve(input);