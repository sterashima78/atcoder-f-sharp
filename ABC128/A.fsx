stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| x; y |] -> (x * 3 + y) / 2
|> printfn "%d"
