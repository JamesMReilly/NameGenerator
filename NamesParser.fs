module NameGenerator.NamesParser

open System.IO

let firstNamePath = "first_names.csv"
let lastNamePath = "last_names.csv"

let names = 0
let probablity = 1

let split (delimeter: char) (row: string) =
  row.Split delimeter

let toTable rows =
  [| for row in rows -> row |>  split ',' |]

let justColumn columnIndex (table: string[][]) =
  [| for row in table -> row.[columnIndex] |]

let toFloatArray arr =
  [| for x in arr -> float x |]

let firstNameTable = File.ReadAllLines firstNamePath|> toTable
let FirstNames = firstNameTable |> justColumn names
let FirstNameProbability = firstNameTable |> justColumn probablity |> toFloatArray


let lastNameTable = File.ReadAllLines lastNamePath |> toTable

let LastNames = lastNameTable |> justColumn names
let LastNameProbability = lastNameTable |> justColumn probablity |> toFloatArray
