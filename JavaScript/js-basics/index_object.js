//Reference types: 
//Object 
//Array 
//Function

// object in code is like an object in real life
// an object will have a name, age, address etc
// object has properties 

//let name = 'Chris';
//let age = 33;
let person = {
   name: 'Chris',
   age: 33 
}; 
// Object literal we add 2 key values into the object, name and age.
// we now don't need the code on line 10 and 11


//we can change the properties of an object

// Dot Notation
person.name = 'Alan';

//Bracket Notation 
person['name'] = 'Mary';

// we can also access a specific property in an object using person.var
console.log(person.name);

// Dot or bracket? Dot should be default, dot notation allows dynamic input 

let selection = 'name';
person[selection] = 'Mary'

//the code above lets the user input a name then the string is passed into the object