stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| m; d |] -> if d >= m then m else m - 1
|> printfn "%d"
