let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

stdin.ReadLine()
|> readIntArray
|> Array.fold (fun (before, current, maxNum) n ->
    if before >= n
    then (n, current + 1L, (max maxNum (current + 1L)))
    else (n, 0L, (max maxNum current))) (0L, 0L, 0L)
|> fun (_, _, m) -> m
|> printfn "%d"
