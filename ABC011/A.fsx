let readInt () = stdin.ReadLine() |> int

readInt ()
|> (+) 1
|> fun x -> if x = 13 then 1 else x
|> printfn "%d"
