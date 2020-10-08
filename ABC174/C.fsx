let readInt _ = stdin.ReadLine() |> int64

()
|> readInt
|> fun x ->
    7L
    |> (%)
    <| x
    |> Seq.unfold (fun before -> Some((before, (before * 10L + 7L) % x)))
    |> Seq.take ((int x))
    |> Seq.tryFindIndex ((=) 0L)
    |> function
    | Some a -> a + 1
    | None -> -1
    |> printfn "%d"
