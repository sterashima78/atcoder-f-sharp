let readInt () = stdin.ReadLine() |> int

readInt ()
|> fun x -> if x % 2 = 0 then x / 2 else x / 2 + 1
|> printfn "%d"
