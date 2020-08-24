let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| a; b; c |] ->
    if a % b <> 0 then a / b * c + c else a / b * c
    |> printfn "%d"
