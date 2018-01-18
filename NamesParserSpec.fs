module NameGenerator.Specs.NamesParserSpec

open NUnit.Framework
open Swensen.Unquote
open System

open NameGenerator.NamesParser

[<Test>]
let ``most common first name is james`` () =
  test <@FirstNames.[0].[0] = "James" @>