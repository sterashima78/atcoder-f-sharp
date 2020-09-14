let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| a; b; c; d |] ->
    if b <= c || d <= a then 0
    elif a <= c && d <= b then d - c
    elif c <= a && b <= d then b - a
    elif a <= c && b <= d then b - c
    else d - a
    |> printfn "%d"
