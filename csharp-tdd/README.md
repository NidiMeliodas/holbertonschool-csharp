# C# Unit Testing Project

## Learning Objectives

At the end of this project, you should be able to explain the following concepts without external help:

### General
- What are solutions in VSCode
- How solutions differ from projects in VSCode
- What is a class library
- What is a unit test
- Benefits of unit testing
- How to create and run tests using NUnit
- The Arrange, Act, Assert methodology
- How to effectively name unit tests
- Utilizing the TDD (Test-Driven Development) approach
- How to consider edge cases

## Requirements

### C# Tasks
- Allowed editor: Visual Studio Code
- All files will be compiled on **Ubuntu 20.04 LTS** using `dotnet`
- A `README.md` file at the root of the project folder is **mandatory**
- Default `Program.cs` files should be renamed as specified in each task
- Each C# task requires its own folder and `.sln` file
- Push all task folders to GitHub with correct task names
- Do **not** push `obj/` or `bin/` folders
- Example `main.cs` files can be used for testing but should **not** be pushed to GitHub
- Public classes and their members must include **XML documentation tags**
- Private classes and members should be documented but **without XML documentation tags**

### C# Tests
- Allowed editor: Visual Studio Code
- All tests must be placed inside a separate folder, named as specified in each task
- All test files will be executed using `dotnet test`
- **Collaborate** on tests to ensure all edge cases are covered

## Project Structure

Each task consists of:
- **One class library** (solving the task)
- **One test library** (to test the class library)

### Steps to Set Up Each Task

1. Create a **task directory** (e.g., `0-add`)
2. Inside the directory, run:
   ```sh
   dotnet new sln
