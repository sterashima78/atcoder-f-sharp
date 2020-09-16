let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| n; r |] ->
    [| 1 .. r |]
    |> Array.collect readIntArray
    |> Array.append [| 1 .. n |]
|> Array.groupBy id
|> Array.sortBy fst
|> Array.map (fun x -> x |> snd |> Array.length |> (-) <| 1 |> string)
|> String.concat "\n"
|> printfn "%s"
