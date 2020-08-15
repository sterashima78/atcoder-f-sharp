let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> Array.sortDescending
|> Array.head
|> printfn "%d"
