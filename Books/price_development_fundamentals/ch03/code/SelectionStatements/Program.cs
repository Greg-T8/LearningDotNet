
// #region Pattern Matching with If Statement
// // Add and remove the "" to change between the string and int.
// object o = 3;
// int j = 4;
// if (o is int i)
// {
//     WriteLine($"{i} x {j} = {i * j}");
// }
// else
// {
//     WriteLine("o is not an int so it cannot multiply!");
// }
// #endregion

// #region Switch Statement

// // Inclusive lower bound but exclusive upper bound.
// int number = Random.Shared.Next(minValue: 1, maxValue: 7);
// WriteLine($"My random number is {number}");
// switch (number)
// {
//   case 1:
//     WriteLine("One");
//     break;                  // Jumps to end of switch statement.
//   case 2:
//     WriteLine("Two");
//     goto case 1;
//   case 3:                   // Multiple case section.
//   case 4:
//     WriteLine("Three or four");
//     goto case 1;
//   case 5:
//     goto A_label;
//   default:
//     WriteLine("Default");
//     break;
// }                           // End of switch statement.
// WriteLine("After end of switch");
// A_label:
// WriteLine($"After A_label");


// #endregion

// #region Pattern matching with switch

// var animals = new Animal?[]
// {
//     new Cat {Name = "Karen", Born = new(year:2022, month:6, day:12)},
//     null,
//     new Cat {Name = "Mufasa", Born = new(year:1994, month:6, day:12)},
//     new Spider {Name = "Sid Vicious", Born = DateTime.Today, IsVenomous = true},
//     new Spider {Name = "Captain Furry", Born = DateTime.Today},
// };

// foreach (Animal? animal in animals)
// {
//     string message;
//     switch (animal)
//     {
//         case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
//             message = $"The cat named {fourLeggedCat.Name} has four legs.";
//             break;
//         case Cat wildCat when wildCat.IsDomestic == false:
//             message = $"The non-domestic cat is named {wildCat.Name}.";
//             break;
//         case Cat cat:
//             message = $"The cat is named {cat.Name}.";
//             break;
//         default: // default is always evaluated last
//             message = $"{animal.Name} is a {animal.GetType().Name}";
//             break;
//         case Spider spider when spider.IsVenomous:
//             message = $"The {spider.Name} spider is venomous. Run!";
//             break;
//         case null:
//             message = $"The animal is null.";
//             break;
//     }
//     WriteLine($"switch statement: {message}");
// }
// #endregion

#region Pattern matching with switch expressions

var animals = new Animal?[]
{
    new Cat {Name = "Karen", Born = new(year:2022, month:6, day:12)},
    null,
    new Cat {Name = "Mufasa", Born = new(year:1994, month:6, day:12)},
    new Spider {Name = "Sid Vicious", Born = DateTime.Today, IsVenomous = true},
    new Spider {Name = "Captain Furry", Born = DateTime.Today},
};

foreach (Animal? animal in animals)
{
    string message;
    message = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4
            => $"The cat named {fourLeggedCat.Name} has four legs.",
        Cat wildCat when wildCat.IsDomestic == false
            => $"The non-domestic cat is named {wildCat.Name}.",
        Cat cat
            => $"The cat is named {cat.Name}.",
        Spider spider when spider.IsVenomous
            => $"The {spider.Name} spider is venomous. Run!",
        null
            => $"The animal is null.",
        _ // Replace the word "default" with an underscore.
            => $"{animal.Name} is a {animal.GetType().Name}"
    };
    WriteLine($"switch statement: {message}");
}

#endregion