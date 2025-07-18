let mutable gas = 100.0
let drive distance =
    if distance = "far" then gas <- gas / 2.0
    elif distance = "medium" then gas <- gas - 10.0
    else gas <- gas - 1.0

drive "far"
drive "near"
drive "far"
drive "medium"
gas