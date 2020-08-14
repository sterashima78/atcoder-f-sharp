stdin.ReadLine().Split(" ")
|> Array.groupBy id
|> Array.length
|> printfn "%d"
