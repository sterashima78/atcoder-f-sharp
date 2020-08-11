stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.sort
|> fun x -> x.[2] - x.[0]
|> printfn "%d"
