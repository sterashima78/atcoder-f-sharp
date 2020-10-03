let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

()
|> readIntArray
|> fun [| n; m |] ->
    seq { 1L .. n }
    |> Seq.map readIntArray
    |> Seq.sortBy (fun [| x; _ |] -> x)
    |> Seq.mapFold (fun (sumPrice, sumNum) [| price; num |] ->
        if sumNum < m && m <= sumNum + num
        then ((sumPrice + price * (m - sumNum), m), (sumPrice + price * (m - sumNum), m))
        else ((sumPrice + price * num, sumNum + num), (sumPrice + price * num, sumNum + num))) (0L, 0L)
    |> fst
    |> Seq.find (fun (_, sumNum) -> sumNum = m)
    |> fst
    |> printfn "%d"
