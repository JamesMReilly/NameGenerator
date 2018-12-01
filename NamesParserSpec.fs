module NameGenerator.Specs.NamesParserSpec

open NUnit.Framework
open Swensen.Unquote

open NameGenerator.NamesParser

[<Test>]
let ``most common first name is james`` () =
  test <@ FirstNames.[0] = "James" @>

[<Test>]
let ``most common name occurs 4% of the time`` () =
  test <@ FirstNameProbability.[0] = 4.000@>

[<Test>]
let ``2nd most commond last name is johnson`` () =
  test <@ LastNames.[1] = "Johnson" @>

[<Test>]
let ``2nd most common last name has summed probability value of 5.5672`` () =
  test <@ LastNameProbability.[1] = 5.5672 @>