// #region while statement
// int x = 0;
// while (x < 10)
// {
//     WriteLine(x);
//     x++;
// }
// #endregion

// #region do statement

// string? actualPassword = "Pa$$w0rd";
// string? password;
// do
// {
//     Write("Enter your password: ");
//     password = ReadLine();
// }
// while (password != actualPassword);
// WriteLine("Correct!");

// #endregion

// #region for statement

// for (int y = 1; y <= 10; y++)
// {
//     WriteLine(y);
// }

// for (int y = 0; y <= 10; y += 3)
// {
//     WriteLine(y);
// }

// #endregion

#region foreach statement

string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}

#endregion