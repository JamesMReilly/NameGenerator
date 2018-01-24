// Learn more about F# at http://fsharp.org

open System
open NameGenerator.NamesParser   
open NameGenerator.NameSelector

let tupleRandomFloats (randomObject: System.Random) =
  (randomObject.NextDouble() * 100. , randomObject.NextDouble() * 100.)

let generateARandomName (firstSeed, lastSeed) =
  let firstName = SelectFirstName firstSeed
  let lastName = SelectLastName lastSeed
  printfn "%s %s" firstName lastName

let generateNRandomNames rnd n =
  for i in 1 .. n do
    rnd |> tupleRandomFloats |> generateARandomName

let (|Int|_|) input = 
  match Int32.TryParse input with
  | (true, i) when i > 0 -> Some i
  | (false, _) -> None

[<EntryPoint>]
let main argv =
  let rnd = new Random()

  match argv with
    | [| Int n |] when n > 0 -> n |> generateNRandomNames rnd
    | _ -> 1 |> generateNRandomNames rnd
  
  
  0 // return an integer exit code
