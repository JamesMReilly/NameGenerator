module NameGenerator.NameSelector

open NameGenerator.NamesParser

let selectName (seed: float) (probList: float[]) =
  let rec loop iter =
    if seed < probList.[iter] then iter
    else loop (iter + 1)
  loop 0

let SelectFirstName seed =
  let index = FirstNameProbability |> selectName seed
  FirstNames.[index]

let SelectLastName seed =
  let index = LastNameProbability |> selectName seed
  LastNames.[index]