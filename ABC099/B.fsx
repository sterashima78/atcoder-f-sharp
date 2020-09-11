let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| a; b |] -> [ 1 .. b - a ] |> List.sum |> (-) <| b
|> printfn "%d"
