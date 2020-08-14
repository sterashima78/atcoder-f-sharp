stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.sum
|> (%)
<| 24
|> printfn "%d"
