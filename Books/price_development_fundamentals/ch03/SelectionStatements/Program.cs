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

var animals = new Animal?[];