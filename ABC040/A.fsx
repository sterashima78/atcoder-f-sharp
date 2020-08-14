stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b |] -> if b - 1 > a - b then a - b else b - 1
|> printfn "%d"
