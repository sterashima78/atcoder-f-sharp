let readInt _ = stdin.ReadLine() |> int

()
|> readInt
|> fun x -> [ 1 .. x ]
|> List.fold (fun map _ ->
    let str = stdin.ReadLine()
    map |> Map.add str 1) Map.empty
|> Map.count
|> printfn "%d"
