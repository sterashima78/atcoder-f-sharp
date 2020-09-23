let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let readInt _ = stdin.ReadLine() |> int

()
|> readIntArray
|> fun [| n; t |] ->
    seq { 1 .. n }
    |> Seq.map readInt
    |> Seq.fold (fun (sum, next) x -> if x < next then (sum + (x + t - next), x + t) else (sum + t, x + t)) (0, 0)
    |> fst
    |> printfn "%d"
