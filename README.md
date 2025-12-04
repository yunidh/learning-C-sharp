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

### 0. Misc.

- `??` Null Coalescing operator, `value/expression1 ?? value/expression2`, where if 1 is null then 2 is used

### 1. Printing:

- `Console.Write` to print without newline
- `Console.WriteLine` to append newline after output

### 2. Literals (Hard coded data types):

- `char`: ' ' single quote, 1 character
- `string`: " " double quote, multiple characters
- `int`: integer value, default number type
- `float`:
  - types of floats:
    - float ~6-9 digits (_use f/F literal suffix_)
    - double ~15-17 digits (_default type if decimal point used in value_)
    - decimal ~28-29 digits (_use m/M literal suffix_)
- `bool`: boolean value, True or False

### 3. Implicitly typed Variable

- `var` keyword to implicitly declare a variable based on infered datatype
- must be initialized, eg:
  - `var message;` will give error (must be initialized)
  - `var message = "hi!"` will work

### 4. String Manipulation

- `@" "`, Verbatim string (next lines, whitespace, and sequences (escape '\s') etc. are printed, verbatim)
- `\u`, Unicode escape sequence (next 4 characters are processed as UTF-16 unicode)
- `$"Text and {code}"`,String interpolation, (can be combined with @)
- `\r`, Carriage return, moves the cursor to the beginning of the current line without advancing to the next line
- `string.Contains("...")`, checks for patterns in string, returns `true` or `false`

### 5. Numbers

- compound assignment operators like +=, -=, \*=, ++, and -- to perform a mathematical operation like increment or decrement, then assign the result into the original variable
- Increment / decrement (++/--), depending on their position, perform their operation before or after they retrieve their value
- By default, `float` values are truncated(_rounded down_) when cast to int (1/2 = 0.5 = (int)0);

### 6. .NET Class Library (useful methods)

- Stateful methods: Must create an instance of the class(object) before being called,
  - Initialize an object: `<className> variableName = new()`
- Stateless methods: Can be called without creating an object, eg: `Console.WriteLine(), Math.Max()`

### 7. Booleans

- && : AND, || : OR, == : equality, != inequality,

### 8. Arrays

- Ways to declare an array:
  - `<datatype>[] variable = {...}`, eg: `int[] numbers = {1,2,3}`
  - `<datatype>[] variable = new <datatype>[n] {...}`, where n = size of array
  - `var variable = new[]{...} OR new[n]`, implicit declaration
  - C#12 and onwards: `<datatype>[] variable = [...]`\*\*
- Properties of array:
  - array.Length (number of elements)
- Iterate over array with `foreach(<datatype> variableForCurrentValue in iterable ){}`

### 10. Switch-case

- `switch expressions`, for better readability and shorter code when only evaluating single expression for return value

```
variable = expression/valueToEvaluate switch
    {
      x or y or z => return value,
      a=> "...",
      b=> "...",
      _ => "...", (default)
    };
```

### 11. System namespace

- `int.TryParse(someString, out intValue)`, returns a `bool`, which can be useful for conditional expressions like:

  - _if (int.TryParse(someString, out int theInt)) { //use theInt here... }_,

- `Array.ForEach(array, methodToApply)`, eg: (array,Console.WriteLine) will apply WriteLine to each element

- `String.Split()`,
