#!/usr/bin/env bash
# Bash script that initializes, builds, and runs a new C# project from a folderdotnet new console -o 2-new_project
dotnet new console -o 2-new_project
cd 2-new_project
dotnet build
dotnet run