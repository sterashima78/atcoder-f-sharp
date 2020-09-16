let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| w; a; b |] ->
    if a < b then if a + w >= b then 0 else b - a - w
    else if b + w >= a then 0
    else a - b - w
|> printfn "%d"
