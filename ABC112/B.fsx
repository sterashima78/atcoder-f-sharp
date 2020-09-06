let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| n; t |] ->
    [ 1 .. n ]
    |> List.map (fun _ -> readIntArray ())
    |> List.filter (fun [| _; time |] -> time <= t)
    |> List.map (fun [| c; _ |] -> c)
    |> List.sort
    |> List.tryHead
    |> fun x ->
        match x with
        | Some x -> x |> string
        | None -> "TLE"
    |> printfn "%s"
