# learning-C-sharp

## Setting up C# locally:

- Download and Install .NET 10, (check with dotnet --version in command line)
- Using VScode, install recommended extensions (C# Devkit and C#)
  - Sign in with Microsoft to use devkit
  - \*\* Ctrl + Shift + P `(>.NET New project/ Console App/ <project name>)`
  - `dotnet run` after CD into project folder to run
- CSharpier extension for code linting (to install CSharpier as local tool, `dotnet tool restore`)

### OR,

-just run individual `.cs` files outside project, `dotnet run <filename>.cs`

## Creating and adding new projects to solution file

- Create dir, CD into dir, refer to \*\* or use `dotnet new console`
  - this creates a Program.cs file and a [directory-name].csproj file
- the .sln file can keep track of projects by linking to .csproj files
  - sln acts like a master index of projects and also contains metadata which streamlines build process
  - _Analogy: <small>If the project files (.csproj) are the individual blueprints for building different rooms (e.g., the kitchen, the living room), the .sln file is the architectural plan that shows how all those rooms fit together to make a complete house</small>_
  - Add all new projects to sln using `dotnet sln learning.sln add **/*.csproj` in bash
  - OR, `dotnet sln learning.sln add [filepath].csproj` for individual projects/ if glob not supported

## Concepts

1. Printing:

- `Console.Write` to print without newline
- `Console.WriteLine` to append newline after output

2. Literals (Hard coded data types):

- `char`: ' ' single quote, 1 character
- `string`: " " double quote, multiple characters
- `int`: integer value, default number type
- `float`:
  - types of floats:
    - float ~6-9 digits (_use f/F literal suffix_)
    - double ~15-17 digits (_default type if decimal point used in value_)
    - decimal ~28-29 digits (_use m/M literal suffix_)
- `bool`: boolean value, True or False

3. Implicitly typed Variable

- `var` keyword to implicitly declare a variable based on infered datatype
- must be initialized, eg:
  - `var message;` will give error (must be initialized)
  - `var message = "hi!"` will work

4. String Manipulation

- `@" "`, Verbatim string (next lines, whitespace, and sequences (escape '\s') etc. are printed, verbatim)
- `\u`, Unicode escape sequence (next 4 characters are processed as UTF-16 unicode)
- `$"Text and {code}"`,String interpolation, (can be combined with @)
- `\r`, Carriage return, moves the cursor to the beginning of the current line without advancing to the next line

5. Numbers

- compound assignment operators like +=, -=, \*=, ++, and -- to perform a mathematical operation like increment or decrement, then assign the result into the original variable
- Increment / decrement (++/--), depending on their position, perform their operation before or after they retrieve their value
- By default, `float` values are truncated(_rounded down_) when cast to int (1/2 = 0.5 = (int)0);
