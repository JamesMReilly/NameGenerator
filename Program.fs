// Learn more about F# at http://fsharp.org

open System
open NameGenerator.NamesParser   
open NameGenerator.NameSelector

[<EntryPoint>]
let main argv =
  let foo = FirstNames
  let snap = foo.[0]
  
  printfn "%s\n" snap

  let crackle = SelectFirstName 0.
  printfn "%s\n" crackle
  0 // return an integer exit code
