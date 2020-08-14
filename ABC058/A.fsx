stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b; c |] ->
    if b - a = c - b then "YES" else "NO"
    |> printfn "%s"
