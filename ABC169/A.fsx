stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.reduce (*)
|> printfn "%d"
