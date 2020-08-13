stdin.ReadLine().Split(" ")
|> Array.map char
|> fun [| a; b |] ->
    if a = b then "="
    else if a < b then "<"
    else ">"
|> printfn "%s"
