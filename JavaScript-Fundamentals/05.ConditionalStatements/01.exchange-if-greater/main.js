function solve(params) {
    let a = +params[0];
    let b = +params[1];

    let smaller = Math.min(a, b);
    let bigger = Math.max(a, b);
    
    console.log(smaller + " " + bigger);

}

solve(['5', '2']);