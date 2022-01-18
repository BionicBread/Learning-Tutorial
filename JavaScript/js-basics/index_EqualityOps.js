// Strict Equality operator (same type and value)
// === and !==
//console.log(1 === 1); // same type and value
//console.log('1' === 1); // '1' is a string and therefore not the same type, return as false 

// Loose equality operator
console.log(1 == 1); // compare 1 with 1
console.log('1' == 1); // compare string 1 with 1, this returns as true
console.log(true == 1); // compare boolean true with 1, 1 and 0 can be used as true/false therefore this will return true

// strict equality operator MUST match type and value 
// Loose equality only match the values 
// Good practise is to use STRICT equality operators