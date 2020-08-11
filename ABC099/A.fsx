stdin.ReadLine()
|> String.length
|> fun x -> if x >= 4 then "ABD" else "ABC"
|> printfn "%s"
