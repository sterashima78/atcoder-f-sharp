stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| n; a; b |] -> if n * a <= b then n * a else b
|> printfn "%d"
