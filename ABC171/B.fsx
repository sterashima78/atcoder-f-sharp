let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| _; num |] ->
    readIntArray ()
    |> Array.sort
    |> Array.take num
    |> Array.reduce (+)
    |> printfn "%d"
