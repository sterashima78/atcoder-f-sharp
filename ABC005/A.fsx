let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> Array.rev
|> Array.reduce (/)
|> printfn "%d"
