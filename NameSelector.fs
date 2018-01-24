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

let generateARandomName (firstSeed, lastSeed) =
  let firstName = SelectFirstName firstSeed
  let lastName = SelectLastName lastSeed
  printfn "%s %s" firstName lastName

let tupleRandomFloats (randomObject: System.Random) =
  (randomObject.NextDouble() * 100. , randomObject.NextDouble() * 100.)

let GenerateNFullNames rnd n =
  for i in 1 .. n do
    rnd |> tupleRandomFloats |> generateARandomName