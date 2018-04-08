# NameGenerator
Random name generator using F# targeting .NET Framework

Built using Visual Studio Code targeting net46 <br/>
NUnit and Unquote for F# unit tests

Inspired by goofy names seen while playing EA Sports NCAA Football 13 with my brother 

### Use
Generates random male names using random numbers to select from several hundred options with varying percentage chance of occurring. 

```fsharp
//generates a single random name
NameGenerator.exe

//generates n random names
NameGenerator.exe n
```

Build NameGenerator.exe using dotnet build command

```bash
dotnet build
```

Run all unit tests with the dotnet test command

```bash
dotnet test
```

### Data

Name data used in the following files is a modified and scaled subset of public domain data (derived from 1990 Census data): <br/>

first_names.csv (Frequently occurring male first names from Census 1990)<br />
last_names.csv (Frequently occurring surnames from the 2010 Census)
