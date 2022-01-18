//Array stores a list of objects
let selectedColours = ['red', 'blue']; //Array literal - with 2 elements red and blue
console.log(selectedColours);
// each element in an array has an index, this index starts at 0 
// to access an specific element in an array a sqaure bracket is used
console.log(selectedColours[0]);
// To add an element to an array
selectedColours[2] = 'green';
console.log(selectedColours);
// this means the length of an array dynamic
// it can also be a number so the type of element in the array is dynamic NOTE other languages cannot do this
selectedColours[2] = 1;
console.log(selectedColours);
// element can be accessed using dot or bracket notation however this time there are special properties
console.log(selectedColours.length);

//ARRAY IS A DATA STRUCTURE THAT IS USED TO LIST OBJECTS