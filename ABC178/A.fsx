let readInt _ = stdin.ReadLine() |> int

readInt ()
|> fun x -> if x = 0 then 1 else 0
|> printfn "%d"
