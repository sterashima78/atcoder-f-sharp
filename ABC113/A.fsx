stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| x; y |] -> x + y / 2 |> printfn "%d"
