age        = 45;                      // Initialize this variable to 45 using a literal value
population = 68_000_000;              // Initialize this variable to 68 million using a literal value
birthdate  = new(1995, 2, 23);        // Initialize this variable to February 23, 1995. C# does not support literal values for date/time values, so we must use `new`
location   = new(10, 20):             // Initialize the X and Y coordinates of this value type
bob        = new();                   // Allocate memory on the heap to store a Person. Any state will have default values. bob is no longer null.
bob        = new("Bob", "Smith", 45)  // Allocate memory on the heap to store a Person and initialize state. bob is no longer null.
                                      //
// Older syntax with explicit types
birthdate = new DateTime(1995, 2, 3);
location = new Point(10, 20);
bob = new Person();
bob = new Person("Bob", "Smith", 45);
