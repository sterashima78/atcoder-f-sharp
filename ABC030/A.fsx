let readFloatArray () =
    stdin.ReadLine().Split(" ") |> Array.map float

readFloatArray ()
|> Array.chunkBySize 2
|> Array.map (fun [| a; b |] -> b / a)
|> fun [| a; b |] ->
    if a = b then "DRAW"
    else if a > b then "TAKAHASHI"
    else "AOKI"
|> printfn "%s"
