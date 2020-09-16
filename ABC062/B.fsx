let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| r; c |] ->
    String.replicate (c + 2) "#" |> printfn "%s"
    [ 1 .. r ]
    |> List.map (fun _ -> "#" + stdin.ReadLine() + "#")
    |> String.concat "\n"
    |> printfn "%s"
    String.replicate (c + 2) "#" |> printfn "%s"
