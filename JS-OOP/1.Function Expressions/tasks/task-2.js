/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {
	if(arguments.length < 2){
		throw new Error();
	}
	let result = [];

	for (let number = +from; number <= +to; number += 1) {
		let sqrt = Math.sqrt(number);

		let isPrime = true;

		for (var i = 2; i <= sqrt; i += 1) {
			if (number % i === 0) {
				isPrime = false;
			}
		}

		if (isPrime && number != 1 && number > 0) {
			result.push(number);

		}
	}

	return result;
}

module.exports = findPrimes;
