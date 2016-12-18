function solve(params) {
    var number = +arguments[0];

    function digitAsAWord(number) {
        var lastDDigit = number % 10;

        switch (lastDDigit) {
            case 0:
                return 'zero';
            case 1:
                return 'one';
            case 2:
                return 'two';
            case 3:
                return 'three';
            case 4:
                return 'four';
            case 5:
                return 'five';
            case 6:
                return 'six';
            case 7:
                return 'seven';
            case 8:
                return 'eight';
            case 9:
                return 'nine';
        }
    }
    console.log(digitAsAWord(number));
}

solve(49);
