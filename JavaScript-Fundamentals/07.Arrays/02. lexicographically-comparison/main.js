function solve(params) {
    var firstString = params[0];
    var secondString = params[1];

    if (firstString.length > secondString.length) {
        console.log('>');
    } else if (firstString.length < secondString.length) {
        console.log('<');
    } else {
        var areEaqual = true;
        for (var i = 0; i < firstString.length; i += 1) {
            if (firstString[i] != secondString[i]) {
                areEaqual = false;
                if (firstString[i] - secondString[i] < 0) {
                    console.log('<');
                } else {
                    console.log('>');
                }
            }

        }

        if (areEaqual) {
            console.log('=');
        }


    }

}

solve(['hello', 'hallo']);