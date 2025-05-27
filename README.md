Add of Fluent Builder Pattern

🔧 Why Do We Need the Fluent API Building Pattern?
1. Improved Readability
Fluent APIs resemble natural language and can make code more self-explanatory.

Example:


builder.SetName("John").SetAge(30).EnableNotifications();
This is more readable than calling separate methods line by line.

2. Method Chaining
You can call multiple methods in a single expression due to each method returning the object itself (usually this).

Reduces boilerplate code and increases conciseness.

3. Flexible Object Construction
Especially useful in cases where constructor overloading would lead to too many combinations.

Fluent APIs allow optional settings without requiring a constructor for each combination.
