let readInt () = stdin.ReadLine() |> int

Seq.initInfinite (fun x -> x |> int64 |> ((+) 1L))
|> Seq.take (readInt ())
|> Seq.filter (fun x -> x % 3L <> 0L && x % 5L <> 0L)
|> Seq.reduce (+)
|> printfn "%d"
