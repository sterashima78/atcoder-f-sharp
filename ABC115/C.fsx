let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let readInt _ = stdin.ReadLine() |> int64

()
|> readIntArray
|> fun [| n; k |] ->
    [ 1 .. n ]
    |> List.map readInt
    |> List.sort
    |> fun s ->
        s
        |> List.take (n - k + 1)
        |> List.zip
        <| (List.skip (k - 1) s)
|> List.map (fun (a, b) -> b - a)
|> List.min
|> printfn "%d"
