// functions are one of the fundemental building block used to perform a task or calculates a value
// the {} is the body of the function, this is where the logic goes
function greet1() {
    console.log('hello world');
}
greet1();
// function can have inputs, these input are declared between the () and is called a PARAMETER. Parameters are only meaningful inside of the function.
// + is used to concatinate aka append together string and variable
function greet2(name) {
    console.log('hello ' + name);
}
// now we can pass Chris as an ARGUMENT for the PARAMETER name 
greet2('Chris');
greet2('Nicola');
// functions can have multiple PARAMETERS 
function greet3(name, lastName) {
    console.log('hello ' + name + ' ' + lastName);
}
greet3('Chris');
greet3('Nicola');

// let's pass with a 2nd ARGUMENT
greet3('Chris', "Yu");
greet3('Nicola', 'Wong');