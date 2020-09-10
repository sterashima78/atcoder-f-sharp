let readInt () = stdin.ReadLine() |> int

()
|> readInt
|> fun x -> [ 1 .. x ]
|> List.map (fun _ -> readInt ())
|> List.groupBy id
|> List.sumBy (fun (_, l) -> l |> List.length |> (-) <| 1)
|> printfn "%A"
