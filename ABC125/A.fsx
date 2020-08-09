stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b; t |] -> t / a * b
|> printfn "%d"
