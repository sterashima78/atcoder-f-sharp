let readInt _ = stdin.ReadLine() |> int

()
|> readInt
|> fun x -> seq { 1 .. x }
|> Seq.map readInt
|> Seq.countBy id
|> Seq.filter (fun (_, n) -> n % 2 = 1)
|> Seq.length
|> printfn "%d"
