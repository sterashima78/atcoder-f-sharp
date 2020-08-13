stdin.ReadLine()
|> int
|> fun x -> x * x - (stdin.ReadLine() |> int)
|> printfn "%d"
