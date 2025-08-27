#if DoNotCompile
#region Increment and addition operators
int x = 3;
int y = 2 + ++x;

WriteLine($"x: {x}, y: {y}");
#endregion


#region Binary shift operators

int x = 3 << 2;
int y = 10 >> 1;

WriteLine($"x: {x}, y: {y}");

#endregion

#endif

#region Bitwise operators

int x = 10 & 8;     // 1010 & 1000 = 1000 = 8
int y = 10 | 7;     // 1010 | 0111 = 1111 = 15

WriteLine($"x: {x}, y: {y}");

#endregion