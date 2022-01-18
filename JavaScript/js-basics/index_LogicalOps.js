// 3 logical operators: AND, OR and NOT.

// Logical AND (&&)
// Returns TRUE if both operands are TRUE
// Console.log(false && true);

// Used to compare two condition that MUST both be TRUE 
// EXAMPLE bank loan

// let highIncome = true;
// let goodCreditScore = true;
// let eligibleForLoan = highIncome && goodCreditScore;

// console.log(eligibleForLoan);

// Same example but for OR (||)
// Returns true if one of the operand is true
// let highIncome = false;
// let goodCreditScore = true;
// let eligibleForLoan = highIncome || goodCreditScore;

// console.log(eligibleForLoan);
let highIncome = false;
let goodCreditScore = false;
let eligibleForLoan = highIncome && goodCreditScore;
console.log('Eligiable', eligibleForLoan)
// NOT (!) the function inverts the value of eligible for Loan 
let applicationRefused = !eligibleForLoan
console.log('Application Refused', applicationRefused);