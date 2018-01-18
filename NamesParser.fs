module NameGenerator.NamesParser

open System.IO

let firstNamePath = "first_names.csv"
let lastNamePath = "last_names.csv"

let split (delimeter: char) (row: string) =
  row.Split delimeter

let toTable rows =
  [| for row in rows -> row |>  split ',' |]

let FirstNames = File.ReadAllLines firstNamePath |> toTable

let LastNames = File.ReadAllLines lastNamePath |> toTable
