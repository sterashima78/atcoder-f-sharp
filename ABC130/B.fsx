let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| _; x |] ->
    ()
    |> readIntArray
    |> Array.mapFold (fun s a -> (s, s + a)) 0
    |> fun (a, b) -> Array.concat [ a; [| b |] ]
    |> Array.filter ((>=) x)
    |> Array.length
    |> printfn "%d"
