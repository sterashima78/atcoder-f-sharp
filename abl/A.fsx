let readInt _ = stdin.ReadLine() |> int

()
|> readInt
|> String.replicate
<| "ACL"
|> printfn "%s"
