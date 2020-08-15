let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> Array.sort
|> Array.zip [| 1; 0 |]
|> Array.map (fun (a, b) -> a + b)
|> Array.reduce (*)
|> printfn "%d"
