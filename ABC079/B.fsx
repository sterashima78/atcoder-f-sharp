let readInt _ = stdin.ReadLine() |> int

seq {
    yield 2L
    yield 1L
    yield! Seq.unfold (fun (a, b) -> Some(a + b, (b, a + b))) (2L, 1L)
}
|> Seq.skip (readInt ())
|> Seq.head
|> printfn "%d"
