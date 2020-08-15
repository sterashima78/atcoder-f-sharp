let read () = stdin.ReadLine()

[ 1 .. 2 ]
|> List.map (fun _ -> read ())
|> List.map (fun x -> (x, x |> String.length))
|> List.sortByDescending (fun (_, a) -> a)
|> List.head
|> fun (x, _) -> x |> printfn "%s"
