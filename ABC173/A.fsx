stdin.ReadLine()
|> int
|> fun x -> x % 1000
|> fun x -> if x = 0 then 0 else 1000 - x
|> printfn "%d"