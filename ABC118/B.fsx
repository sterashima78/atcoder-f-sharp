let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| n; _ |] ->
    [| 1 .. n |]
    |> Array.collect (fun _ -> readIntArray () |> Array.tail)
    |> Array.groupBy id
    |> Array.map (fun (_, arr) -> arr |> Array.length)
    |> Array.filter ((=) n)
    |> Array.length
    |> printfn "%d"
