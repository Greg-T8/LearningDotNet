let addThreeDays (theDate:System.DateTime) =
    theDate.AddDays 3

let addAYearAndThreeDays theDate =
    let threeDaysForward = addThreeDays theDate
    theDate.AddYears 1


let x = getData()
let x:Customer list = getData()

let customersToRemind =  loadOverDueCustomers()

