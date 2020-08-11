stdin.ReadLine()
|> int
|> fun x -> if x % 2 = 0 then (x / 2) * (x / 2) else ((x + 1) / 2) * ((x - 1) / 2)
|> printfn "%d"
