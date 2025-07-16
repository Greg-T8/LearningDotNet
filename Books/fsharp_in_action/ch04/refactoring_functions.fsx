open System

let calculateAgeDescription age =
    if age < 18 then "Child"
    elif age < 65 then "Adult"
    else "OAP"

let describeAge age =
    let ageDescription = calculateAgeDescription age
    let greeting = "Hello"
    printfn $"{greeting}! You are a '{ageDescription}'."
