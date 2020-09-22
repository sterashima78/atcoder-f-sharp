let toExponentials n =
    seq {
        yield 1
        for p in 2 .. n do
            yield!
                Seq.unfold (fun s ->
                    let a = pown p s
                    if a > n then None else Some(a, s + 1)) 2
    }

let readInt _ = stdin.ReadLine() |> int

()
|> readInt
|> toExponentials
|> Seq.max
|> printfn "%d"
