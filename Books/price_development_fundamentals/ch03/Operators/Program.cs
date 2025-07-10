#region Exploring Unary Operators
int a = 3;
int b = a++;    // postfix increment operates after the value is assigned
WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c;    // prefix increment operates before the value is assigned
WriteLine($"c is {c}, d is {d}");

#endregion