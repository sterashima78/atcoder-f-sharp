let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| a; b; c; k |] ->
    let [| s; t |] = readIntArray ()
    let x = a * s + b * t
    let y = if s + t >= k then (s + t) * c else 0
    x - y |> printfn "%d"
