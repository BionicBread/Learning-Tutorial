// exercise: swap the two outputs so a diplays 'blue' and b displays 'red'
// method 1
// let a = 'blue';
// let b = 'red';

// let array = [a,b]

// function swapA(x,y)
// {
//     return x = y; 
// }
// function swapB(x,y)
// {
//     return x = y; 
// }
// a = swapA(array[0],array[1]);
// b = swapB(array[1],array[0]);

// console.log(a);
// console.log(b);

// answer; use a 3rd variable to store then inject the inversion
let a = 'blue';
let b = 'red';

let c = a; 
a = b;
b = c; 

console.log(a);
console.log(b);
