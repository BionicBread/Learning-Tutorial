// if and else 
// hour
// if hour is between 6am and 12 pm display Good morning
// otherwise, Good evening
// if (condition) {
//      statement
// }
// else if (anotherCondition){
//  statement 
// }
// as many 'else if' condition
// 'else' will terminate the if loop

let hour = 10;

if (hour >= 6 && hour < 12){
    console.log('good morning');
}
else if (hour >= 12 && hour < 18){
    console.log('good afternoon');
}
else if (hour >= 18 || hour = 00){
    console.log('good evening');
}
else if (hour >=00 && hour < 6){
    console.log('good night');
}
break