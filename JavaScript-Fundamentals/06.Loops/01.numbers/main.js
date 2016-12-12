function solve(params) {
    let n = +params[0];
    let result = "";
    for (var i = 1; i <= n; i++) {
        result += i + " ";
        
    }

   result = result.trim();

   console.log(result);
}

solve(['5']);