function solve(params) {
    const excpresion = params[0];

    let brscketCount = 0;
    let output = 'Correct';

    for (let i = 0; i < excpresion.length ; i += 1) {
        if (excpresion[i] === '(') {
            brscketCount += 1;
        } else if (excpresion[i] == ')') {
            brscketCount -= 1;
        }

        if (brscketCount < 0) {
            output = 'Incorrect';
            break;
        }
    }

    if (brscketCount !== 0) {
        output = 'Incorrect';
    }

    console.log(output);
}

solve([ '((a+b)/5-d)' ]);