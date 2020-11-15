let readInt _ = stdin.ReadLine() |> int

()
|> readInt
|> fun x -> if x < 0 then 0 else x
|> printfn "%d"
