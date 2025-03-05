# "Questions in ArrayList" C# Program

## Overview
This C# program allows the user to input multiple questions, which are then stored dynamically in an `ArrayList`. The program prompts the user for the number of questions they want to enter, collects each question, and finally displays the list of questions entered by the user.

## Features
- User-friendly console prompts for entering questions.
- Dynamic storage of user input using an `ArrayList`.
- Error handling to manage invalid inputs (e.g., non-integer input for number of questions).
- Displays the list of questions in the order they were entered.

## Requirements
- .NET Framework or .NET Core for compiling and running the C# program.
- A text editor or an Integrated Development Environment (IDE) like Visual Studio, Visual Studio Code, or JetBrains Rider for writing and editing C# code.

## How to Use
1. **Clone/Download the repository**:
   - You can either clone this repository using Git or download the `.zip` file to your local machine.

2. **Compile and Run the Program**:
   - Open the project in an IDE like Visual Studio or Visual Studio Code.
   - Build and run the program.

3. **Input Questions**:
   - When prompted, enter the number of questions you would like to input (e.g., `3` for 3 questions).
   - For each prompt, type the question and press `Enter`.
   
4. **View Results**:
   - After all questions are entered, the program will display the list of questions with their corresponding numbers.

## Example Run

```text
Please enter the number of question(s): 
3
Enter question number 1: 
What is your name?
Enter question number 2: 
What is your age?
Enter question number 3: 
Where do you live?

Questions entered:

Question 1: What is your name?
Question 2: What is your age?
Question 3: Where do you live?
```

## Code Walkthrough

- **Input Handling**: The program first prompts the user for the number of questions they would like to input. It then uses a `for` loop to collect each question. The questions are stored in an `ArrayList` to allow for dynamic size, meaning the number of questions is not fixed at the time of writing the program.
  
- **Error Handling**: If the user enters a non-numeric value when prompted for the number of questions, an exception is thrown and caught by the `catch` block, providing the user with an error message.

- **Displaying Questions**: After all questions are collected, the program iterates over the `ArrayList` and prints each question with its corresponding number.

## Error Handling
The program contains basic error handling for scenarios such as:
- Non-numeric input when asking for the number of questions.
- Any unforeseen errors that may occur during execution.

---
