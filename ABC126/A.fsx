stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| _; k |] ->
    stdin.ReadLine().ToCharArray()
    |> Array.indexed
    |> Array.map (fun (i, c) -> if i = (k - 1) then System.Char.ToLower c else c)
    |> System.String
    |> printfn "%s"
