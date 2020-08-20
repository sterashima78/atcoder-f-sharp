let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| _; a |] ->
    readIntArray ()
    |> Array.filter ((<=) a)
    |> Array.length
    |> printfn "%d"
