function solve(params) {
    let a = +params[0];
    let b = +params[1];
    let c = +params[2];


    let min = Math.min(a ,b ,c);
    let max = Math.max(a, b, c);
    let sum = a + b + c;
    let avrg = sum / 3;
    // min=1.00
    // max=5.00
    // sum=8.00
    // avg=2.67
    console.log(`min=${min.toFixed(2)}`);
    console.log(`max=${max.toFixed(2)}`);
    console.log(`sum=${sum.toFixed(2)}`);
    console.log(`avrg=${avrg.toFixed(2)}`);
}

solve(['2', '5', '1']);