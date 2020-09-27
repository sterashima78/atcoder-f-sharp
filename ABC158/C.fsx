let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| a; b |] ->
    seq { 1 .. 1010 }
    |> Seq.filter (fun i ->
        let x =
            i |> float |> (/) <| 12.5 |> int |> (=) a

        let y = i / 10 |> (=) b
        x && y)
    |> Seq.tryHead
|> fun x ->
    match x with
    | None -> -1
    | Some y -> y
|> printfn "%d"
