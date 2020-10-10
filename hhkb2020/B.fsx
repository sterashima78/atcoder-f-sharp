let readCharArray _ = stdin.ReadLine().ToCharArray()

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec solve count list =
    match list with
    | []
    | [ _ ] -> count
    | (_, _, '.') :: (r, c, '.') :: x -> solve (count + 1) ((r, c, '.') :: x)
    | _ :: xx -> solve count xx

()
|> readIntArray
|> fun [| h; w |] ->
    [| 1 .. h |]
    |> Array.map (readCharArray >> Array.indexed)
    |> Array.indexed
    |> Array.collect (fun (r, arr) -> arr |> Array.map (fun (c, str) -> (r, c, str)))
    |> Array.toList
    |> fun list ->
        let countC =
            list
            |> List.groupBy (fun (c, _, _) -> c)
            |> List.sumBy (snd >> (solve 0))

        let countR =
            list
            |> List.groupBy (fun (_, r, _) -> r)
            |> List.sumBy (snd >> (solve 0))

        countR + countC
|> printfn "%d"
