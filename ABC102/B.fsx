let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int64

stdin.ReadLine()

()
|> readIntArray
|> fun x -> (x |> Array.max) - (x |> Array.min)
|> printfn "%d"
