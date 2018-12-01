// Learn more about F# at http://fsharp.org

open System
open NameGenerator.NamesParser   
open NameGenerator.NameSelector

let tupleRandomFloats (randomObject: System.Random) =
  (randomObject.NextDouble() * 100. , randomObject.NextDouble() * 100.)


[<EntryPoint>]
let main argv =
  let rnd = new Random()
  let (firstSeed,lastSeed) = rnd |> tupleRandomFloats
  let firstName = SelectFirstName firstSeed
  let lastName = SelectLastName lastSeed

  printfn "%s %s" firstName lastName

  0 // return an integer exit code
