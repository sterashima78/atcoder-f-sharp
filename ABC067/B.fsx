let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| _; x |] ->
    ()
    |> readIntArray
    |> Array.sortDescending
    |> Array.take x
    |> Array.sum
    |> printfn "%d"
