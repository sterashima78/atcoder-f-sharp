let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

stdin.ReadLine()

readIntArray ()
|> Array.indexed
|> fun x ->
    [ for (i1, a) in x do
        for (i2, b) in x |> Array.filter (fun (i, _) -> i > i1) do
            for (_, c) in x |> Array.filter (fun (i, _) -> i > i2) -> [ a; b; c ] ]
|> List.map List.sortDescending
|> List.filter (fun [ a; b; c ] -> a < b + c && a <> b && b <> c)
|> List.length
|> printfn "%d"
