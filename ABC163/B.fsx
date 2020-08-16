let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| n; _ |] ->
    readIntArray ()
    |> Array.reduce (+)
    |> (-) n
    |> fun x -> if x < 0 then -1 else x
    |> printfn "%d"
