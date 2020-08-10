stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b; c |] -> if b / a > c then c else b / a
|> printfn "%d"
