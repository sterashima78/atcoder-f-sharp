stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b |] -> Array.max [| a + b; a - b; a * b |]
|> printfn "%d"
