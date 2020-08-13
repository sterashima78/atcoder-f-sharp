stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b; c |] -> if a <= c && c <= b then "Yes" else "No"
|> printfn "%s"
