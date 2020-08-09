let [| a; b |] =
    stdin.ReadLine().Split(" ") |> Array.map int

(if a - b * 2 > 0 then a - b * 2 else 0)
|> printfn "%d"
