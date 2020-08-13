stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| x; a; b |] ->
    if a >= b then "delicious"
    else if (b - a) <= x then "safe"
    else "dangerous"
|> printfn "%s"
