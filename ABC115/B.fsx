let readInt () = stdin.ReadLine() |> int

()
|> readInt
|> fun x -> [ 1 .. x ]
|> List.map (fun _ -> readInt ())
|> List.sortDescending
|> fun l ->
    (l |> List.head |> (/) <| 2)
    + (l |> List.tail |> List.sum)
|> printfn "%d"
