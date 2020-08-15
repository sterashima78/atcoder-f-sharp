let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| a; b; c |] -> (a * b + b * c + c * a) * 2
|> printfn "%d"
