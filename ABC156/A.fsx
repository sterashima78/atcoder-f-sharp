let [| a; b |] =
    stdin.ReadLine().Split(" ") |> Array.map int

if a >= 10 then b else b + (100 * (10 - a))
|> printfn "%d"
