function solve(args){
    let width = +args[0];
    let height = +args[1];

    let parameter = 2 * (width + height);
    let area = width * height;

    console.log(`${area.toFixed(2)} ${parameter.toFixed(2)}`);

}

solve([ '2.5', '3' ]);
solve([ '5', '5' ]);
