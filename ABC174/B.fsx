let [| n; d |] =
    stdin.ReadLine().Split(" ") |> Array.map int64

[ for i in int64 (1) .. n do
    stdin.ReadLine().Split(" ")
    |> Array.map int64
    |> (fun [| x; y |] -> x * x + y * y) ]
|> List.filter (fun x -> x <= (d * d))
|> List.length
|> printfn "%d"
