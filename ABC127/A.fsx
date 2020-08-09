stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b |] ->
    if a >= 13 then b
    else if a > 5 then b / 2
    else 0
|> printfn "%d"
