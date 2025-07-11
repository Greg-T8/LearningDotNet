// #region Exploring Unary Operators
// int a = 3;
// int b = a++;    // postfix increment operates after the value is assigned
// WriteLine($"a is {a}, b is {b}");

// int c = 3;
// int d = ++c;    // prefix increment operates before the value is assigned
// WriteLine($"c is {c}, d is {d}");

// #endregion

// #region Exploring Binary Operators

// int e = 11;
// int f = 3;
// WriteLine($"e is {e}, f is {f}");
// WriteLine($"e + f = {e + f}");
// WriteLine($"e - f = {e - f}");
// WriteLine($"e * f = {e * f}");
// WriteLine($"e / f = {e / f}");
// WriteLine($"e % f = {e % f}");

// #endregion

// #region

// double g = 11.0;
// WriteLine($"g is {g:N1}, f is {f}");
// WriteLine($"g / f = {g / f}");

// #endregion

// #region Assignment Operators

// int p = 6;
// p += 3;     // equivalent to p = p + 3
// p -= 3;     // equivalent to p = p - 3
// p *= 3;     // equivalent to p = p * 3
// p /= 3;     // equivalent to p = p / 3

// #endregion


// #region Logical Operators
// bool p = true;
// bool q = false;
// WriteLine($"AND  | p     | q    ");
// WriteLine($"p    | {p & p,-5} | {p & q,-5} ");
// WriteLine($"q    | {q & p,-5} | {q & q,-5} ");
// WriteLine();
// WriteLine($"OR   | p     | q    ");
// WriteLine($"p    | {p | p,-5} | {p | q,-5} ");
// WriteLine($"q    | {q | p,-5} | {q | q,-5} ");
// WriteLine();
// WriteLine($"XOR  | p     | q    ");
// WriteLine($"p    | {p ^ p,-5} | {p ^ q,-5} ");
// WriteLine($"q    | {q ^ p,-5} | {q ^ q,-5} ");

// #endregion

// #region Conditional Logical Operators

// static bool DoStuff()
// {
//     WriteLine("I am doing some stuff.");
//     return true;
// }

// bool p = true;
// bool q = false;
// WriteLine();
// WriteLine($"p & DoStuff() = {p & DoStuff()}");          // p & DoStuff() = True
// WriteLine($"q & DoStuff() = {q & DoStuff()}");          // q & DoStuff() = False

// WriteLine($"p && DoStuff() = {p && DoStuff()}");        // p && DoStuff() = True
// WriteLine($"q && DoStuff() = {q && DoStuff()}");        // q && DoStuff() = False, DoStuff() was not called

// #endregion

#region Bitwise Operators
WriteLine();
int x = 10;
int y = 6;
WriteLine($"Expression | Decimal | Binary");
WriteLine($"-------------------------------------");
WriteLine($"x          | {x,7} | {x:B8}");
WriteLine($"y          | {y,7} | {y:B8}");
WriteLine($"x & y      | {x & y,7} | {x & y:B8}");
WriteLine($"x | y      | {x | y,7} | {x | y:B8}");
WriteLine($"x ^ y      | {x ^ y,7} | {x ^ y:B8}");
WriteLine($"x << 3     | {x << 3,7} | {x << 3:B8}");
WriteLine($"x * 8      | {x * 8,7} | {x * 8:B8}");
WriteLine($"y >> 1     | {y >> 1,7} | {y >> 1:B8}");

#endregion
