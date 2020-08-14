stdin.ReadLine()
|> fun x ->
    match x with
    | "a"
    | "i"
    | "u"
    | "e"
    | "o" -> "vowel"
    | _ -> "consonant"
|> printfn "%s"
