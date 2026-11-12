# Sales & Stock – C# Project

## Overview

This project was created to practice and consolidate C# development skills through a structured, hands-on development experience.

The main learning goals are:

- Programming logic and problem-solving
- Object-Oriented Programming (OOP)
- Separation of concerns and modular design
- Clean Code and SOLID principles
- Unit testing
- Git, GitHub, pull requests, and code reviews

The application reads a provided XML file (`Sales_Stock.xml`) and analyzes product sales and inventory data. Development begins with a console application; a graphical interface is planned as a future enhancement.

---

## Artificial Intelligence Usage

### Guidelines

AI should be used as a **support tool, not as a shortcut**. The purpose of the project is to develop independent problem-solving skills.

**Recommended usage:**

- Clarifying programming concepts
- Discussing possible approaches and trade-offs
- Reviewing existing logic and structure
- Improving documentation
- Organizing ideas and investigating errors

**Avoid:**

- Requesting complete solutions without attempting the task first
- Copying generated code without understanding it
- Replacing individual reasoning and the learning process

---

## Core Concepts

### Programming Fundamentals

- Variables, data types, and operators
- Conditions: `if`, `else if`, `else`
- Loops: `for`, `foreach`, `while`
- Methods, parameters, and return values
- Collections and basic data validation

### Object-Oriented Programming

- Classes, objects, and properties
- Interfaces and abstraction
- Encapsulation and separation of concerns
- Dependency injection using MEF
- Modular and maintainable code

### Best Practices

- SOLID principles
- Clean Code
- Meaningful naming conventions
- Small, focused methods
- XML documentation
- Exception handling

---

## Technologies

- **Language:** C#
- **Application:** .NET console application
- **Data source:** XML (`Sales_Stock.xml`)
- **Dependency injection:** Managed Extensibility Framework (MEF)
- **Unit testing:** NUnit
- **Mocking:** Moq (`MockRepository`, `MockBehavior.Strict`)
- **Version control:** Git and GitHub

---

## Project Structure

The solution separates responsibilities across controllers, models, services, interfaces, and supporting components.

The following structure illustrates the current approach and the planned test project; not every file or service is implemented yet.

```text
SalesStockAnalyzer/
├── Controller/
│   └── ReportController.cs
├── Enums/
│   └── MenuOption.cs
├── Handlers/
│   └── XmlHandler.cs
├── Models/
│   ├── ProductModel.cs
│   └── ProductsModel.cs
├── Services/
│   ├── Interface/
│   │   └── IBestSellingProductService.cs
│   └── BestSellingProductService.cs
└── Program.cs

SalesStockAnalyzer.Unit.Tests/   # Planned dedicated test project
├── Controller/
├── Handlers/
└── Services/
```

Additional reporting services and their corresponding interfaces will follow the same structure.

---

## Features

The system reads and processes data from `Sales_Stock.xml` through the following menu options:

| Option | Report |
| --- | --- |
| 1 | Quantity of products in stock |
| 2 | Total sales value of products in stock |
| 3 | Best-selling product |
| 4 | Most profitable product |
| 5 | Products that have not been sold |
| 6 | Out-of-stock products |
| 7 | Execute all options |
| 8 | Exit |

Each reporting feature is implemented as an independent service, exposed through an interface and invoked by `ReportController`. The `MenuOption` enum represents menu selections without hardcoded string cases.

**Implementation status:** The best-selling product service is the initial working example. Remaining services are tracked as GitHub issues.

---

## Unit Testing

A dedicated `SalesStockAnalyzer.Unit.Tests` project will validate business logic and support future refactoring.

### Conventions

- Use NUnit attributes such as `[TestFixture]`, `[SetUp]`, and `[Test]`.
- Follow the **AAA pattern**: Arrange, Act, Assert.
- Use `MockRepository` with `MockBehavior.Strict` for mocked dependencies when appropriate.
- Verify expected interactions with `VerifyAll()` where applicable.
- Keep tests independent, deterministic, and focused on observable behavior.
- Cover valid inputs, invalid data, edge cases, and expected exceptions.

The **Unit Testing Guidelines PDF** attached to the relevant GitHub issue is the primary reference for detailed test conventions.

---

## XML Documentation Standards

Use C# XML documentation throughout the project to improve readability and IntelliSense support.

- Use `/// <summary>` to describe classes, interfaces, methods, and relevant properties.
- Use `<param>` for method parameters and `<returns>` for return values.
- Use `<see cref="..."/>` to reference existing types when appropriate.
- Document relevant private methods when doing so adds clarity.

For **MEF imports**, follow this specific convention:

```csharp
/// <summary>
/// Instance of <see cref="ILogger"/>.
/// </summary>
[Import]
public ILogger Logger { get; set; }
```

Apply the same pattern to other imported interfaces, such as `IBestSellingProductService`.

---

## Development Workflow

The project is organized to simulate a real software development workflow:

1. Select and understand a GitHub issue and its acceptance criteria.
2. Create a dedicated development branch.
3. Implement the feature or improvement.
4. Add or update unit tests where applicable.
5. Open a pull request describing the changes.
6. Participate in code review and address feedback.
7. Merge the approved changes.

During reviews, focus on **reasoning, readability, correctness, and learning**, not only on whether the code runs.

---

## Objectives — Module 1: Core Console Application

The first module aims to deliver a stable, fully functional console application while strengthening:

- Logical reasoning and fundamental C# skills
- Object-oriented design and SOLID principles
- Separation of responsibilities across project layers
- XML parsing and product data analysis
- Independent reporting services and MEF integration
- Basic input validation and exception handling
- Consistent XML documentation
- Reliable unit tests using NUnit and Moq
- GitHub issue management, pull requests, and regular code reviews

**Completion criteria:** All menu options and reporting services work as expected in the console, and the relevant tests pass.

---

## Future Improvements — Module 2: Advanced

After the core console application is complete and validated, consider:

- More comprehensive input and data validation (negative values, inconsistent records)
- Business rules for duplicate products (for example, selecting the latest `ModificationDate`)
- Improved domain modeling and separation of responsibilities
- Broader unit test coverage for edge cases
- Basic logging for system operations and failures
- Further refactoring for readability and maintainability

### Graphical User Interface (GUI)

A modern GUI is a **future enhancement**, not a requirement for Module 1.

GUI development should begin **only after all console services are implemented, tested, and working correctly**. This phase will likely require refactoring the current services to **return data rather than write directly to the console**, so the same business logic can be reused by a desktop or web interface.

Potential technologies include WPF, Avalonia UI, and Blazor; the final choice will be evaluated when this phase begins.

---

## Project Goal

The goal is not only to build a working application, but also to practice a realistic development process: understanding requirements, implementing solutions, testing, documenting, reviewing code, and continuously improving technical decisions.
