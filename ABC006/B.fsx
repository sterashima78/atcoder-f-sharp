let readInt () = stdin.ReadLine() |> int

()
|> readInt
|> fun n ->
    seq {
        yield 0
        yield 0
        yield 1
        yield! Seq.unfold (fun state ->
                   let (a, b, c) = state
                   let n = (a + b + c) % 10007
                   Some(n, (b, c, n))) (0, 0, 1)
    }
    |> Seq.skip (n - 1)
    |> Seq.head
|> printfn "%d"
