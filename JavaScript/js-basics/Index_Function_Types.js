// performing a task 
function greet(name, lastName){
    console.log('Hello ' + name + '' + lastName);  //Template literal can be used to clean up the concatination 
}

greet('John', 'Smith');

//calculates a value, use the return keyword,
function square(number){
    return number*number; 
}

let number = square(2); 
console.log(number); // displays number variable
//.log is a function also 