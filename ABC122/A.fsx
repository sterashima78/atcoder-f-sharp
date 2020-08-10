stdin.ReadLine()
|> fun c ->
    match c with
    | "A" -> "T"
    | "T" -> "A"
    | "C" -> "G"
    | "G" -> "C"
    | _ -> "N"
|> printfn "%s"
