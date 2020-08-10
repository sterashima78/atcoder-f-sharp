let a = stdin.ReadLine() |> int
stdin.ReadLine() |> int
stdin.ReadLine() |> int
stdin.ReadLine() |> int
let e = stdin.ReadLine() |> int

stdin.ReadLine()
|> int
|> fun k ->
    if e - a <= k then "Yay!" else ":("
    |> printfn "%s"
