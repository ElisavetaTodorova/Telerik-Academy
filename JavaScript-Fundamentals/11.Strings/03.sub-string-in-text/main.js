function solve(params) {
    const searchedWord = params[0];
    const text = params[1];

    let count = 0;

    let index = text.indexOf(searchedWord);

    while(index != -1){
        count += 1;

        index = text.indexOf(searchedWord , index + 1);
    }
    console.log(count);
}

solve([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);