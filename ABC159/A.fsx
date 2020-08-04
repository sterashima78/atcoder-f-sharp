let solve x = if x >= 2 then x * (x - 1) / 2 else 0

let [| a; b |] =
    stdin.ReadLine().Split(" ") |> Array.map int

solve (a) + solve (b) |> printfn "%d"
