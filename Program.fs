// Learn more about F# at http://fsharp.org

open System
open NameGenerator.NameSelector

let (|Int|_|) input = 
  match Int32.TryParse input with
  | (true, i) when i > 0 -> Some i
  | (false, _) -> None

[<EntryPoint>]
let main argv =
  let rnd = Random()

  match argv with
    | [| Int n |] when n > 0 -> n |> GenerateNFullNames rnd
    | _ -> 1 |> GenerateNFullNames rnd
  
  0 // return an integer exit code
