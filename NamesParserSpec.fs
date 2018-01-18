module NameGenerator.Specs.NamesParserSpec

open NUnit.Framework
open Swensen.Unquote
open System

open NameGenerator.NamesParser

[<Test>]
let ``most common first name is james`` () =
  test <@ FirstNames.[0].[0] = "James" @>

[<Test>]
let ``most common name occurs 4% of the time`` () =
  test <@ (float FirstNames.[0].[1]) = 4.000@>