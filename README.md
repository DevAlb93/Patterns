## Code Refactor 
## Magic Strings
![image](https://github.com/user-attachments/assets/5f3d4e23-e1f5-43ae-bac3-810878b567eb)
![image](https://github.com/user-attachments/assets/404b5c9a-e791-49bb-b490-5d30bed89df8)
![image](https://github.com/user-attachments/assets/334e2f7d-fc89-43a7-ad28-661e6dc06944)













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
