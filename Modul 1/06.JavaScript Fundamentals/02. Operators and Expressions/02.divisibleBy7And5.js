/* Write a boolean expression that checks for given integer if it 
can be divided (without remainder) by 7 and 5 in the same time. */

function divisibleBy7And5(number) {
    if (number % 5 == 0 && number % 7 == 0) {
        return 'The number is divisible by 7 and 5.';
    }
    else {
        return 'The number is not divisible by 7 and 5';
    }
}

console.log(divisibleBy7And5(35));
console.log(divisibleBy7And5(5));
console.log(divisibleBy7And5(7));
console.log(divisibleBy7And5(175));
console.log(divisibleBy7And5(21));
console.log(divisibleBy7And5(20));