let readInt _ = stdin.ReadLine() |> int

()
|> readInt
|> Seq.init
<| id
|> Seq.map readInt
|> Seq.sort
|> Seq.indexed
|> Seq.map (fun (i, r) -> if i % 2 = 0 then r * r else -1 * r * r)
|> Seq.reduce (+)
|> float
|> (*) System.Math.PI
|> abs
|> printfn "%f"
