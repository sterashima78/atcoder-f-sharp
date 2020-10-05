let readDecimalArray _ =
    stdin.ReadLine().Split(" ") |> Array.map decimal

()
|> readDecimalArray
|> Array.reduce (*)
|> int64
|> printfn "%d"
