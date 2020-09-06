let readInt () = stdin.ReadLine() |> int

()
|> readInt
|> fun x -> [ 1 .. x ]
|> List.map (fun _ -> readInt ())
|> List.sort
|> List.head
|> printfn "%d"
