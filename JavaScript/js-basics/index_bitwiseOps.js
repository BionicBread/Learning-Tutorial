// Some CS theory behind this operator
// binary format of numbers 
// 1 = 00000001 
// 2 = 00000010

//console.log(1 | 2); //bitwise OR 
// compares each bit 
// 1 = 00000001 
// 2 = 00000010
// R = 00000011 = 3 

//console.log(1 & 2); //bitwise AND 
// 1 = 00000001 
// 2 = 00000010
// R = 00000000

// Example: Access control system
// User can have Read, Write and Execute
// We can use 1 byte to determine type of permission a user can have.
// READ, WRITE, EXECUTE
// 0000100 = read
// 0000110 = write
// 0000111 = execute
//
const readPermission = 4;
const writePermission = 2; 
const executePermission = 1;

let myPermission = 0;
myPermission = myPermission | readPermission | writePermission;
console.log(myPermission);

let readMessage =
(myPermission & readPermission)? 'yes': 'no';

console.log('Do you have read permission:', readMessage); 

//the bitwise OR can be used to add permission and the bitwise AND can be used to check permissions