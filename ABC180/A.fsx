let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| n; a; b |] -> n - a + b
|> printfn "%d"
