# Lab02
![Screenshot](Assets/Screenshot.png)
## The Problem Domain
+ Create a bank “ATM” program within a console application
### Program Specifications
Using Test Driven Development, build out a console application that mocks the functionality of an ATM. Your solution should include the following methods:

+ ### Main method
  + Call the user interface method to activate the application
### Testable external methods:
## ViewBalance()
  + Functionality: Returns the value of the current balance
  + Return: decimal
  + Test to ensure that the balance properly shows the correct amount after each transaction
## Withdraw()
  + Functionality: Subtracts money from the balance
  + Return: decimal
  + Do not allow the user to withdraw more money than what’s available.
  + Do not allow the user to withdraw a value less than zero.
## Deposit()
  + Return: decimal
  + Functionality: Adds money to the balance
  + Do not allow the user to deposit a negative amount
## Variable to hold the current Balance of the account.
  + Make this a static public decimal Balance variable, declared above the Main() method. This will allow you to access the Balance variable anywhere in this Program.cs file.
### User interface that prompts the user for standard ATM operations that links to each of the above external methods
  + Return : void
  + Keep asking the user to choose a transaction until they choose to ‘exit’ the application. (while loop??)
  + This method is where you will want to hold all of your Console.ReadLines.
  + This method does NOT need to be tested.
## A few things to keep in mind:
  + Make sure the user can’t go below a zero balance.
  + You cannot unit test console WriteLine or Readlines.
  + Make sure your methods are just returning values and not reading input from the console.
  + Remember to use the proper data types while working within the program. Money is usually represented by decimals.
  + All methods within the program class should start their method signature with static public followed by the return type and method name. Example public static void UserInterface()
## Unit Tests
  + Write unit tests in a new project using the XUnit library. Test the functionality for the above application. Here are the testing requirements:

  + Test every method/action (that does not require user input); there should be a passing valid input, and a passing invalid input.
  + Have at least 2 tests for every non-void method.
  + A failing test, is not a valid test - even if the failure is expected.