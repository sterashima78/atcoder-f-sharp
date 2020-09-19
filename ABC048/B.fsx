let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

()
|> readIntArray
|> fun [| a; b; x |] ->
    if a % x = 0L then (b / x) - (a / x) + 1L else (b / x) - (a / x)
    |> printfn "%d"
