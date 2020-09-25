let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

()
|> readIntArray
|> fun [| n; k |] ->
    ()
    |> readIntArray
    |> Array.sortDescending
    |> Array.skip (min n k |> int)
    |> Array.sum
    |> printfn "%d"
