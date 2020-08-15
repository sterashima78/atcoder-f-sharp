let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| a; b; c |] -> if a > b then c / b else c / a
|> printfn "%d"
