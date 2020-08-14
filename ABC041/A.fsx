stdin.ReadLine().ToCharArray()
|> Array.take (stdin.ReadLine() |> int)
|> Array.rev
|> Array.head
|> string
|> printfn "%s"
