let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

()
|> readIntArray
|> fun [| s; c |] ->
    let x = min s (c / 2L)
    x + (c - 2L * x) / 4L |> printfn "%d"
