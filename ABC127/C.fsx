let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| n; m |] ->
    [ 1 .. m ]
    |> List.fold (fun (left, right) _ ->
        ()
        |> readIntArray
        |> (fun [| l; r |] -> (max left l, min r right))) (1, n)
|> fun (l, r) -> if r >= l then r - l + 1 else 0
|> printfn "%d"
