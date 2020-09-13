let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

()
|> readIntArray
|> fun [| a; b; c; d |] ->
    if a >= 0L && c >= 0L then b * d
    else if b <= 0L && d <= 0L then a * c
    else if b <= 0L && c >= 0L then b * c
    else if a >= 0L && d <= 0L then a * d
    else if a * c > b * d then a * c
    else b * d
|> printfn "%d"
