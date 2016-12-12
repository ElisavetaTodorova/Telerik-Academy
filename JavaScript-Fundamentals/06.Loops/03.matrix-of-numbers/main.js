function solve(params) {
    let n = +params[0];

    let result = "";
    let numberToWrite = 1;
    let count = 1;
    for (let i = 1; i <= n * n; i += 1) {
        result += numberToWrite + " ";
        numberToWrite += 1;
         if (i % n === 0) {
             count += 1;
            numberToWrite = count;
            result = result.trim();
            result += '\r\n';

        }
    }

    console.log(result);
}

solve(['2']);