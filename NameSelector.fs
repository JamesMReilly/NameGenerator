module NameGenerator.NameSelector

open System
open NameGenerator.NamesParser

let firstNames = NamesParser.FirstNames
let lastNames = NamesParser.LastNames
let nameIndex = 1

let selectName seed (nameList: string[][]) =
  let rec loop iter =
    if seed < nameList.[iter].[nameIndex] then nameList.[iter].[nameIndex]
    else loop (iter + 1)
  loop 0

let SelectFirstName seed =
  firstNames |> selectName seed

let SelectLastName seed =
  lastNames |> selectName seed