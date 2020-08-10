let rec solve v rest a b =
    match rest with
    | 0 -> v
    | r -> if a > b then solve (v + a) (r - 1) (a - 1) b else solve (v + b) (r - 1) a (b - 1)

stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b |] -> solve 0 2 a b
|> printfn "%d"
