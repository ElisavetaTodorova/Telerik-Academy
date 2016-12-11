function solve(args) {
    let number = + args[0];

    var bit = (number & (1 << 3)) >> 3;

    console.log(bit);
}

solve(['1024']);