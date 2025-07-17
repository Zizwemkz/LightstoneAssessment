# Reverse Words Console Application

<div align="center">
  <h1>
    Reverse Words Console Application
  </h1>
  <p>
    A simple, extensible C# console application that reverses the order of words in multiple lines of input, using clean object-oriented design and the S.O.L.I.D principles. 
    This project demonstrates good software engineering practices, including testability and clear separation of concerns, making it a perfect starting point for learning C# OOP patterns.
  </p>
</div>

## Key Features

- **Word Reversal:** Reverses the order of words in each input line.
- **Batch Processing:** Collects all test case inputs first, then outputs all results together.
- **S.O.L.I.D Principles:** Adheres to object-oriented best practices.
- **Testable Design:** Includes simple unit tests for core logic.
- **Single File Simplicity:** All code and tests are contained in a single `.cs` file for easy understanding and portability.

## Project Structure

- **IWordReverser:** Interface for the word reversal service.
- **WordReverser:** Concrete implementation that handles reversing logic.
- **Program:** Main entry point that collects input, processes cases, and displays output.
- **UnitTests (optional):** Simple built-in test suite for validating core logic.

## Getting Started

### Prerequisites

- [.NET 6.0 SDK or later](https://dotnet.microsoft.com/download)
- Any C#-compatible IDE (Visual Studio, VS Code, JetBrains Rider, etc.)

### Setup

1. **Clone or download the repository.**
2. **Open the project folder in your preferred C# IDE.**
3. **Place the `Program.cs` file in your console project (or run as a standalone single-file app).**

### Running the Application

1. **Build the project:**
    ```sh
    dotnet build
    ```
2. **Run the application:**
    ```sh
    dotnet run
    ```
3. **Follow the prompts:**
    - Enter the number of test cases (N).
    - For each case, enter a line of space-separated words.
    - After all input, the reversed results are displayed in order.

#### Example

**Input:**
```
Enter the number of test cases (N):
3
For each test case, enter a line of space-separated words:
Input for case 1: this is a test
Input for case 2: foobar
Input for case 3: all your base
```

**Output:**
```
Results:
case1: test a is this
case2: foobar
case3: base your all
```

### Running Unit Tests

To run the built-in unit tests, uncomment the line `// UnitTests.RunAll();` in `Main()` and run the application. The application will execute the test suite and exit.

## Design Overview

The application is structured to demonstrate:
- **Separation of Concerns:** Each class or interface handles a single responsibility.
- **Testability:** Logic is easily testable through explicit interfaces.
- **Extensibility:** Easy to add new word-processing features or extend input/output methods.

### Main Components

- **WordReverser:** Handles the core logic for reversing words in a line.
- **Program:** Orchestrates user interaction, collects input, and manages output.
- **UnitTests:** Provides basic validation of the main logic.

