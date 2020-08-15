let readInt () = stdin.ReadLine() |> int

readInt ()
|> fun x -> (x / 2) * (x / 2)
|> printfn "%d"
