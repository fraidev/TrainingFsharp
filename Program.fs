// Learn more about F# at http://fsharp.org

open System
open System

module BasicFunctions = 
     let sampleFunction1 x = x*x + 3
     
[<EntryPoint>]
let main argv = 
    printfn "Hello World from F#!"
    let num = BasicFunctions.sampleFunction1(2)
    printfn "%d" num
    
    
    
    
    0 // return an integer exit code