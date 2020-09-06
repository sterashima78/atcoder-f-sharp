let readInt () = stdin.ReadLine() |> int

()
|> readInt
|> fun x -> [| 1 .. x |]
|> Array.map (fun _ -> stdin.ReadLine())
|> Array.groupBy id
|> Array.sortByDescending (fun x -> x |> snd |> Array.length)
|> Array.head
|> fst
|> printfn "%s"
