stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.reduce (-)
|> fun x -> x + 1
|> printfn "%d"
