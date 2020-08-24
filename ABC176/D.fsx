let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let readCharArray () = stdin.ReadLine().ToCharArray()

readIntArray ()
|> fun [| h; w |] ->
    readIntArray ()
    |> fun [| initH; initW |] ->
        readIntArray ()
        |> fun [| finH; finW |] ->
            [| 1 .. h |]
            |> Array.collect (fun x ->
                ()
                |> readCharArray
                |> Array.indexed
                |> Array.map (fun (i, v) -> (x, i + 1, v)))
|> printfn "%A"
