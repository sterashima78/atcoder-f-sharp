let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| n; k |] ->
    [ 1 .. k ]
    |> List.map (fun _ ->
        readIntArray ()
        readIntArray ())
    |> List.reduce Array.append
    |> Array.groupBy id
    |> Array.length
    |> (-) n
    |> printfn "%d"
