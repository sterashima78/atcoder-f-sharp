stdin.ReadLine()
|> int
|> fun x ->
    match x with
    | 7
    | 5
    | 3 -> "YES"
    | _ -> "NO"
|> printfn "%s"
