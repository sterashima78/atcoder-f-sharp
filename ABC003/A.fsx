let readInt () = stdin.ReadLine() |> int

readInt ()
|> float
|> (+) 1.0
|> (/)
<| 2.0
|> (*) 10000.0
|> int
|> printfn "%d"
