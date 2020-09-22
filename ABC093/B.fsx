let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| a; b; k |] ->
    let sm =
        seq { a .. b }
        |> Seq.indexed
        |> Seq.takeWhile (fun (i, _) -> i < k)
        |> Seq.map snd

    let lg =
        seq { b .. -1 .. a }
        |> Seq.indexed
        |> Seq.takeWhile (fun (i, _) -> i < k)
        |> Seq.map snd

    Seq.concat [ sm; lg ]
    |> Seq.groupBy id
    |> Seq.map fst
    |> Seq.sort
    |> Seq.map string
    |> Seq.toArray
    |> String.concat "\n"
    |> printfn "%s"
