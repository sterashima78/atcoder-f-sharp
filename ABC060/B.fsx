let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| a; b; c |] ->
    Seq.init b (fun i -> a * (i + 1) % b)
    |> Seq.tryFind (fun x -> x = c)
    |> fun x ->
        match x with
        | Some _ -> "YES"
        | None -> "NO"
    |> printfn "%s"
