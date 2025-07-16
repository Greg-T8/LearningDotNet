let printAddition a b =
    let answer = a + b
    printfn $"{a} plus {b} is {answer}."


let getTheCurrentTime = System.DateTime.Now         // Calculates the current time and assigns it to a symbo
let x = getTheCurrentTime                           // Copies the value of getCurrentTime to another symbol
let y = getTheCurrentTime                           // Copies the value of getCurrentTime to another symbol


// let getTheCurrrentTime () = System.DateTime.Now
// let x = getTheCurrrentTime ()                       // Calls the function to get the current time
// let y = getTheCurrrentTime ()                       // Calls the function to get the current time again


let addDays days =
    let newDays = System.DateTime.Today.AddDays days
    printfn $"You gave me {days} days and I gave you {newDays}."
    newDays
let result = addDays 3


let addSeveralDays () =
    addDays 1
    addDays 2
    addDays 3

let addSeveralDays () =
    ignore (addDays 3)
    ignore (addDays 5)
    addDays 7
