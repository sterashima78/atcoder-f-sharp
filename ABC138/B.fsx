let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| x; y |] ->
    [ (y - x + 1) .. (y + x - 1) ]
    |> List.map string
    |> String.concat " "
    |> printfn "%s"
