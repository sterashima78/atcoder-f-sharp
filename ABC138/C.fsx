let readFloatArray _ =
    stdin.ReadLine().Split(" ") |> Array.map float

stdin.ReadLine()
|> readFloatArray
|> Array.sort
|> Array.reduce (fun before current -> (before + current) / 2.0)
|> printfn "%f"
