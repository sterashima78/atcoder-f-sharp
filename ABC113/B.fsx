let readFloatArray () =
    stdin.ReadLine().Split(" ") |> Array.map float

stdin.ReadLine()

()
|> readFloatArray
|> fun [| t; a |] ->
    ()
    |> readFloatArray
    |> Array.indexed
    |> Array.sortBy (fun (_, h) -> t - h * 0.006 - a |> abs)
    |> Array.head
    |> fun (i, _) -> i + 1
    |> printfn "%d"
