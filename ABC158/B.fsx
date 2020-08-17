let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int64

readIntArray ()
|> fun [| n; a; b |] ->
    let x = n / (a + b) * a
    let y = n % (a + b)
    if y < a then x + y else x + a
|> printfn "%d"
