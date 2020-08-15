let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| a; b |] ->
    if b % a = 0 then b / a else b / a + 1
    |> printfn "%d"
