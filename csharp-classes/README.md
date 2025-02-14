# C# Object-Oriented Programming & XML Documentation

## Learning Objectives

By the end of this project, you should be able to explain the following concepts without using Google:

### General Concepts
- How to document C# code with XML comments
- What is object-oriented programming?
- What is a namespace?
- What is a class?
- What are objects and instances?
- Difference between a class and an object or instance
- What is a field?
- What is a constructor?
- What is a property?
- How to use `get` and `set`
- When to use a constructor and when to use a property
- What is `this` and when to use it
- What is a method?
- What are access modifiers?
- What is a static class?
- What is a static member?
- What is encapsulation?
- What is polymorphism?
- What is abstraction?
- What does `ToString` do and how to override it?
- Difference between a class and a struct
- When to use a class and when to use a struct
- What is garbage collection in C#?

---

## Requirements

### General
1. **Editors**: Use **Visual Studio Code**.
2. **Compilation**: All files will be compiled on **Ubuntu 20.04 LTS** using `dotnet`.
3. **Mandatory**: A `README.md` file must be present at the root of the project folder.
4. **File Naming**: Rename all default C# files named `Program.cs` to the specified name in each task.
5. **Folder Structure**:
   - Each C# task must have its own folder.
   - Each task must have its own `.csproj` file.
6. **GitHub Guidelines**:
   - Push all task folders to your GitHub repository.
   - Ensure folder names match the task names correctly.
7. **Exclusions**:
   - Do not push `obj/` or `bin/` folders to your repository.
8. **Testing Files**:
   - Example `main.cs` files are provided for testing your functions.
   - You are not required to push `main.cs` files to your repository.
   - Note: The evaluation process will use custom `main.cs` files for compilation, which might differ from the provided examples.

---

## Documentation Requirements

Starting from this project, **documenting your code is required!** Follow these guidelines:

- Use **XML documentation comments**.
- Follow **XML Documentation Best Practices**:
  - All **public types/classes and their members** must be documented using `<summary>` tags.
  - **Private members** should be documented but without XML documentation tags.
- To enable XML documentation in your project, **add the following line** inside the `<PropertyGroup>` in your `.csproj` file:

  ```xml
  <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>
