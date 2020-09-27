let readInt _ = stdin.ReadLine() |> int

()
|> readInt
|> fun x -> [ 1 .. x ]
|> List.map readInt
|> fun l ->
    let [ m1; m2 ] = l |> List.sortDescending |> List.take 2
    (m1, m2, l)
|> fun (m1, m2, l) ->
    for i in l do
        if i = m1 then printfn "%d" m2 else printfn "%d" m1
