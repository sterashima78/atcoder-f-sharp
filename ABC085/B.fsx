let readInt _ = stdin.ReadLine() |> int

()
|> readInt
|> fun x -> [ 1 .. x ]
|> List.map readInt
|> List.groupBy id
|> List.length
|> printfn "%d"
