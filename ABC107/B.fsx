let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let readCharArray _ = stdin.ReadLine().ToCharArray()
let third (_, _, c) = c

let isNotAllBlank arr =
    arr
    |> Array.groupBy third
    |> fun x -> not (x.Length = 1 && (x.[0] |> fst |> (=) '.'))

()
|> readIntArray
|> fun [| h; w |] ->
    [| 1 .. h |]
    |> Array.map (fun a -> a |> readCharArray |> Array.indexed)
    |> Array.indexed
    |> Array.collect (fun (r, arr) -> arr |> Array.map (fun (c, v) -> (r, c, v)))
    |> Array.groupBy (fun (_, c, _) -> c)
    |> Array.filter (fun (_, arr) -> arr |> isNotAllBlank)
    |> Array.collect snd
    |> Array.groupBy (fun (r, _, _) -> r)
    |> Array.filter (fun (_, arr) -> arr |> isNotAllBlank)
    |> Array.map (fun (_, arr) ->
        arr
        |> Array.map (fun (_, _, c) -> c)
        |> System.String)
    |> String.concat "\n"
    |> printfn "%s"
