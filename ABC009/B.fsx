let readInt () = stdin.ReadLine() |> int

()
|> readInt
|> fun x -> [| 1 .. x |]
|> Array.map (fun _ -> () |> readInt)
|> Array.groupBy id
|> Array.sortByDescending fst
|> Array.skip 1
|> Array.head
|> fst
|> printfn "%d"
