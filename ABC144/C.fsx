let readInt _ = stdin.ReadLine() |> int64

()
|> readInt
|> fun x ->
    seq { 1L .. (x |> double |> sqrt |> int64 |> (+) 1L) }
    |> Seq.filter (fun a -> a * a <= x && x % a = 0L)
    |> Seq.minBy (fun a -> x / a + a - 2L)
    |> fun a -> x / a + a - 2L
    |> printfn "%d"
