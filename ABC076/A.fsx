stdin.ReadLine()
|> int
|> fun x ->
    stdin.ReadLine()
    |> int
    |> (*) 2
    |> (-)
    <| x
    |> printfn "%d"
