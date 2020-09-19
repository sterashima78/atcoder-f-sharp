let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| a; _ |] ->
    [| 1 .. a |]
    |> Array.collect (fun _ ->
        let x = stdin.ReadLine()
        [| x; x |])
    |> String.concat "\n"
    |> printfn "%s"
