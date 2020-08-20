let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int64

readIntArray ()
|> fun [| a; b; k |] ->
    if a >= k then [| a - k; b |]
    else if b >= k - a then [| 0L; b - (k - a) |]
    else [| 0L; 0L |]
|> Array.map string
|> String.concat " "
|> printfn "%s"
