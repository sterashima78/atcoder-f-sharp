let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| a; _ |] ->
    [| 1 .. a |]
    |> Array.map (fun _ -> stdin.ReadLine())
    |> Array.sort
    |> String.concat ""
    |> printfn "%s"
