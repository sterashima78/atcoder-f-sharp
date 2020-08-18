let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| n; k; m |] ->
    readIntArray ()
    |> Array.sum
    |> fun x ->
        if x >= m * n then 0
        else if x + k >= m * n then m * n - x
        else -1
    |> printfn "%d"
