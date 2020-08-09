let [| n; a; b |] =
    stdin.ReadLine().Split(" ") |> Array.map int

(if n * a > b then b else n * a) |> printfn "%d"
