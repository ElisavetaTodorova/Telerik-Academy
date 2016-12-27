function solve(params) {
    const str = params[0];
    let result = [];

    for (let i = str.length - 1; i >= 0; i -= 1) {
            result.push(str[i]);
    }

    console.log(result.join(''));
}

solve([ 'qwertytrewq' ]);