let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| width; height; n |] ->
    let cells =
        seq {
            for w in 1 .. width do
                for h in 1 .. height do
                    (w, h)
        }

    [| 1 .. n |]
    |> Array.map readIntArray
    |> Array.fold (fun s [| x; y; a |] ->
        match a with
        | 1 -> s |> Seq.filter (fun (w, _) -> w > x)
        | 2 -> s |> Seq.filter (fun (w, _) -> w <= x)
        | 3 -> s |> Seq.filter (fun (_, h) -> h > y)
        | _ -> s |> Seq.filter (fun (_, h) -> h <= y)) cells
    |> Seq.length
    |> printfn "%d"
