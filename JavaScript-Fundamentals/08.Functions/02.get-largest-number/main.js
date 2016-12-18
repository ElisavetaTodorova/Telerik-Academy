function solve(params) {
    var array = arguments[0].split(' ').map(x => +x);

    function getMax(array) {
        return Math.max(...array);
    }
    
    console.log(getMax(array));
}

solve('1 3 4');