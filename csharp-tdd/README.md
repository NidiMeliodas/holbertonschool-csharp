# C# - Test Driven Development

This project introduces **Test-Driven Development (TDD)** in C# using **NUnit**.  
It involves creating class libraries and unit tests following the TDD approach and .NET conventions.

---

## 📚 Resources

- Unit Testing Tutorial for C# Developers (0:00 to 12:16)
- TDD Basics with C#
- Unit Testing C# with NUnit and .NET Core
- NUnit Documentation
- NUnit.Framework Documentation
- NUnit Cheat Sheet
- When to use static classes in C#
- Target .NET Frameworks

---

## 🎯 Learning Objectives

At the end of this project, you should be able to explain:

- What are solutions in VSCode
- How solutions differ from projects in VSCode
- What is a class library
- What is a unit test
- The benefits of unit testing
- How to create and run tests using **NUnit**
- The **Arrange, Act, Assert** methodology
- How to name your unit tests clearly and effectively
- How to apply the **TDD** approach
- How to identify and test edge cases

---

## ✅ Requirements

### General

- Editor: **Visual Studio Code**
- OS: **Ubuntu 20.04 LTS**
- Language: **C#**
- A `README.md` at the root of the project is mandatory
- All C# files must be renamed from `Program.cs` to the task's given name
- Each task requires its own folder and `.sln` file
- Do not push `bin/` or `obj/` folders
- Example `main.cs` files used for testing should not be pushed
- All public classes and members must have **XML documentation**
- All private classes and members should be documented (non-XML)

---

## ✅ Requirements - C# Tests

- Tests must be in a **separate folder** named appropriately
- Tests are executed using:
  ```bash
  dotnet test

/0-add
├── 0-add.sln
├── /MyMath
│   ├── MyMath.cs
│   └── MyMath.csproj
└── /MyMath.Tests
    ├── MyMath.Tests.cs
    └── MyMath.Tests.csproj
🛠️ Steps to Set Up Each Task
Create a task directory:

bash
mkdir 0-add && cd 0-add
dotnet new sln
Create class library:

bash
mkdir MyMath && cd MyMath
dotnet new classlib
mv Class1.cs MyMath.cs
Enable XML docs in MyMath.csproj:

xml
<PropertyGroup>
  <TargetFramework>netstandard2.0</TargetFramework>
  <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>
</PropertyGroup>
Add class library to solution:

bash
cd ..
dotnet sln add MyMath/MyMath.csproj
Create test library:

bash
mkdir MyMath.Tests && cd MyMath.Tests
dotnet new nunit
mv UnitTest1.cs MyMath.Tests.cs
dotnet add reference ../MyMath/MyMath.csproj
Add test project to solution:

bash
cd ..
dotnet sln add MyMath.Tests/MyMath.Tests.csproj
(Optional) Add console app to run manually:

bash
mkdir MyMath.Console && cd MyMath.Console
dotnet new console
dotnet add reference ../MyMath/MyMath.csproj