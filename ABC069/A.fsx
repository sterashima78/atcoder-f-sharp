stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.map ((-) <| 1)
|> Array.reduce (*)
|> printfn "%d"
