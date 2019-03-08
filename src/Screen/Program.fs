open System
open StartProcess

let PS = Processor.StartProcess

[<EntryPoint>]
let main argv =

    PS("echo hello, world!")

    0
