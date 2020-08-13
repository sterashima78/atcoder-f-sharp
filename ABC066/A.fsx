stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.sort
|> Array.take 2
|> Array.reduce (+)
|> printfn "%d"
