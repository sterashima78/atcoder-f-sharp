let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| a; b |] ->
    [ a |> string |> String.replicate b
      b |> string |> String.replicate a ]
    |> List.min
|> printfn "%s"
