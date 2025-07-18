let drive gas distance =
    if distance = "far" then gas / 2
    elif distance = "medium" then gas - 1
    else gas - 1

let gas = 100
let firstState = drive gas "far"
let secondState =  drive firstState "medium"
let thirdState = drive secondState "near"
