stdin.ReadLine()
|> int
|> fun x ->
    if x < 1200 then "ABC"
    else if x < 2800 then "ARC"
    else "AGC"
|> printfn "%s"
