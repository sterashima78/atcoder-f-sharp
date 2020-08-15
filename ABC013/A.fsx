stdin.ReadLine()
|> fun x ->
    match x with
    | "A" -> 1
    | "B" -> 2
    | "C" -> 3
    | "D" -> 4
    | _ -> 5
|> printfn "%d"
