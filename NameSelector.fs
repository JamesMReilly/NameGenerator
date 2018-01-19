module NameGenerator.NameSelector

open NameGenerator.NamesParser

let selectName (probList: float[]) (seed: float) =
  let rec loop iter =
    if seed <= probList.[iter] then iter
    else loop (iter + 1)
  loop 0

let SelectFirstName seed =
  let index = seed|> selectName FirstNameProbability
  FirstNames.[index]

let SelectLastName seed =
  let index = seed |> selectName LastNameProbability
  LastNames.[index]