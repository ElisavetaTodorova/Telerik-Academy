function solve(params) {

    var n = +params[0];

    var array = [];

    for (var i = 0; i < n; i += 1) {
        array.push(+params[1 + i]);
    }

    var sorted = selectionSort(array);

    function selectionSort(items) {

        var len = items.length,
            min;

        for (i = 0; i < len; i++) {

            //set minimum to this position
            min = i;

            //check the rest of the array to see if anything is smaller
            for (j = i + 1; j < len; j++) {
                if (items[j] < items[min]) {
                    min = j;
                }
            }

            //if the minimum isn't in the position, swap it
            if (i != min) {
                swap(items, i, min);
            }
        }

        return items;
    }

    function swap(items, firstIndex, secondIndex) {
        var temp = items[firstIndex];
        items[firstIndex] = items[secondIndex];
        items[secondIndex] = temp;
    }

    console.log(sorted);
}

solve(['10', '36', '10', '1', '34', '28', '38', '31', '27', '30', '20']);