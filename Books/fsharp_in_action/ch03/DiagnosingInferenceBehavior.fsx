let calculateGroup (age:int) =
    if age < "test" then "Child"
    elif age < 65 then "Adult"
    else "Pensioner"

let sayHello someValue =
    let group =
        if someValue < 10.0 then calculateGroup 15
        else calculateGroup 35
    "Hello " +  group

let result = sayHello 10.5