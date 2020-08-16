let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| a; b; c; k |] ->
    if a >= k then k
    else if a + b >= k then a
    else a - (k - a - b)
|> printfn "%d"
