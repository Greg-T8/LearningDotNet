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


#region Logical Operators
bool p = true;
bool q = false;
WriteLine($"AND  | p     | q    ");
WriteLine($"p    | {p & p,-5} | {p & q,-5} ");
WriteLine($"q    | {q & p,-5} | {q & q,-5} ");
WriteLine();
WriteLine($"OR   | p     | q    ");
WriteLine($"p    | {p | p,-5} | {p | q,-5} ");
WriteLine($"q    | {q | p,-5} | {q | q,-5} ");
WriteLine();
WriteLine($"XOR  | p     | q    ");
WriteLine($"p    | {p ^ p,-5} | {p ^ q,-5} ");
WriteLine($"q    | {q ^ p,-5} | {q ^ q,-5} ");

#endregion
