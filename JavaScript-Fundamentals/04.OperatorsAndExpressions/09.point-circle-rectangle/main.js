function solve(params) {
    let x = +params[0];
    let y = +params[1];

    let valueToBeInTheCircle = Math.sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1)));

    let inCircle = valueToBeInTheCircle <= 1.5;
    
    let inRectangle = (x <= 5 && x >= -1) && (y <= 1 && y >= -1);
    
    if(inCircle && inRectangle){
        console.log('inside circle inside rectangle');
    } else if (inCircle){
        console.log('inside circle outside rectangle');
    } else if (inRectangle){
        console.log('outside circle inside rectangle');   
    } else {
        console.log('outside circle outside rectangle');
    }
}

solve(['2.5', '2']);