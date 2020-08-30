let readInt () = stdin.ReadLine() |> int

()
|> readInt
|> Array.zeroCreate
|> Array.map (fun _ ->
    stdin.ReadLine().Split(" ")
    |> (fun [| c; s |] -> (c, int s * -1)))
|> Array.indexed
|> Array.sortBy (fun (_, (c, s)) -> (c, s))
|> Array.map (fun (i, _) -> i + 1 |> string)
|> String.concat "\n"
|> printfn "%s"
