let readCharArray _ = stdin.ReadLine().ToCharArray()
let readInt _ = stdin.ReadLine() |> int

()
|> readInt
|> fun x -> [| 1 .. x |]
|> Array.map readCharArray
|> Array.map Array.indexed
|> Array.indexed
|> Array.collect (fun (r, arr) -> arr |> Array.map (fun (c, ch) -> (r, c, ch)))
|> Array.groupBy (fun (_, c, _) -> c)
|> Array.map (fun x ->
    x
    |> snd
    |> Array.sortByDescending (fun (r, _, _) -> r)
    |> Array.map (fun (_, _, ch) -> ch)
    |> System.String)
|> String.concat "\n"
|> printfn "%s"
