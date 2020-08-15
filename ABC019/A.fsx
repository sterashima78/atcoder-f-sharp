let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> Array.sort
|> Array.take 2
|> Array.rev
|> Array.head
|> printfn "%d"
