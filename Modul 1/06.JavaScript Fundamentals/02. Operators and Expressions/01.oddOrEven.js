/* Write an expression that checks if given integer is odd or even. */

function oddOrEven(number) {
    if (number % 2 == 0) {
        return true;
    }
    else {
        return false;
    }
}

console.log(oddOrEven(14));
console.log(oddOrEven(1));
console.log(oddOrEven(12));
console.log(oddOrEven(2));
console.log(oddOrEven(10000));
console.log(oddOrEven(13));
