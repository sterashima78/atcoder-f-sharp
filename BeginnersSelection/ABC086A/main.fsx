stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.reduce (*)
|> (%)
<| 2
|> fun i -> if i = 1 then "Odd" else "Even"
|> printfn "%s"
