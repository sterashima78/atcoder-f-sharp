stdin.ReadLine()
|> int
|> fun x -> if x < 1200 then "ABC" else "ARC"
|> printfn "%s"
