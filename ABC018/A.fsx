let readInt () = stdin.ReadLine() |> int

[ 1 .. 3 ]
|> List.map (fun _ -> readInt ())
|> List.indexed
|> List.sortByDescending (fun (_, y) -> y)
|> List.indexed
|> List.sortBy (fun (_, (x, _)) -> x)
|> List.map (fun (x, _) -> x + 1 |> printfn "%d")
