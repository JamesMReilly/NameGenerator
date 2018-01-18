// Learn more about F# at http://fsharp.org

open System
open NameGenerator.NamesParser   

[<EntryPoint>]
let main argv =
    let foo = FirstNames
    let snap = foo.[0]
    let bar = foo.[0].[0]
    printfn "%s\n" bar
    0 // return an integer exit code
