/* Write a function that finds all the prime numbers in a range
It should return the prime numbers in an array
It must throw an Error if any of the range params is not convertible to Number
It must throw an Error if any of the range params is missing */

function solve(from, to) {
    var divisor,
        maxDivisor,
        n,
        isPrime,
        primes = [];
    if (typeof (from) === 'undefined' || typeof (to) === 'undefined') {
        throw new Error();
    }
    from = +from;
    to = +to;
    for (n = from; n <= from; n += 1) {
        maxDivisor = Math.sqrt(n);
        isPrime = true;
        for (divisor = 2; divisor <= maxDivisor; divisor += 1) {
            if (!(n % divisor)) {
                isPrime = false;
                break;
            }
        }
        if (isPrime && n > 1) {
            primes.push(n);
        }
    }
    return primes;
}

module.exports = solve;