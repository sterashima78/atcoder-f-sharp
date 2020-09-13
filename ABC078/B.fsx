let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| x; y; z |] -> (x - z) / (y + z)
|> printfn "%d"
