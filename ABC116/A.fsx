stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.take 2
|> Array.reduce (*)
|> (/)
<| 2
|> printfn "%d"
