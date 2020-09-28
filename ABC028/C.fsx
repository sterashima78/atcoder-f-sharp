let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun x ->
    seq {
        for i1 in x do
            for i2 in x do
                if i2 > i1 then
                    for i3 in x do
                        if i3 > i2 then i1 + i2 + i3
    }
    |> Seq.sortDescending
    |> Seq.skip 2
    |> Seq.head
    |> printfn "%d"
