let readInt _ = stdin.ReadLine() |> int64

()
|> readInt
|> fun x -> if x % 2L = 0L then x - 1L else x + 1L
|> printfn "%d"
