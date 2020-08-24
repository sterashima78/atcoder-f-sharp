let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| x; _ |] ->
    [| 1 .. x |]
    |> Array.map (fun _ -> readIntArray ())
|> Array.indexed
|> fun x ->
    [| for (i1, v1) in x do
        for (i2, v2) in x do
            if i1 < i2 then
                v1
                |> Array.zip v2
                |> Array.sumBy (fun (a, b) -> (a - b) * (a - b))
                |> (fun x ->
                    let y = x |> float |> sqrt |> int
                    y * y = x) |]
|> Array.filter id
|> Array.length
|> printfn "%d"
