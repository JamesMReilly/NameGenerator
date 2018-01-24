# NameGenerator
Random name generator using F# targeting .NET Framework

### Use
Generates random male names using random numbers to select from several hundred options with varying percentage chance of occurring. 

```fsharp
//generates a single random name
NameGenerator.exe

//generates n random names
NameGenerator.exe n
```

### Data

Name data used in the following files is a modified and scaled subset of public domain data (derived from 1990 Census data): <br/>

first_names.csv (Frequently occurring male first names from Census 1990)<br />
last_names.csv (Frequently occurring surnames from the 2010 Census)
