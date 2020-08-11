stdin.ReadLine()
|> int64
|> fun x -> if x % int64 2 = int64 0 then x else x * int64 2
|> printfn "%d"
