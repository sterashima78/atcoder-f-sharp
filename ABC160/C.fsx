let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| k; n |] ->
    let arr = () |> readIntArray
    let lastToEnd = arr.[n - 1] - k
    arr
    |> Array.fold (fun (maxNum, before, sum) current ->
        let d = current - before
        let newMax = if maxNum < d then d else maxNum
        (newMax, current, sum + d)) (0, lastToEnd, 0)
    |> fun (m, _, s) -> s - m
    |> printfn "%d"
