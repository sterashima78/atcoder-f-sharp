let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| a; b |] -> printfn "%d %d" ((a + b) / 2) ((a - b) / 2)
