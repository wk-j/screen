﻿open System
open StartProcess

let PS = Processor.StartProcess

type Options = { Init: bool; Command: string }

let rec parse options args =
    match args with
    | "--init" :: xs
    | "-i" :: xs -> parse { options with Init = true } xs
    | "--command" :: xs
    | "-c" :: xs ->
        match xs with
        | value :: xss -> parse { options with Command = value } xss
        | _ -> parse options xs
    | _ -> options

[<EntryPoint>]
let main argv =

    let options = parse { Init = false; Command = "pwd" } (List.ofArray argv)

    if options.Init then
        PS("""/bin/bash -c "screen -ls | grep wk-screen | cut -d. -f1 | awk '{print $1}' | xargs kill" """)
        PS("screen -S wk-screen")

    else
        let template =
            """/bin/bash -c "screen -S wk-screen -X stuff '{command}'$(echo -ne '\015')" """

        let cmd = template.Replace("{command}", options.Command)
        PS(cmd)

    0
