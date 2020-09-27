let readFloat _ = stdin.ReadLine() |> float

()
|> readFloat
|> fun x -> x * x * x / 27.0
|> printfn "%f"
