let readInt _ = stdin.ReadLine() |> int


readInt ()
|> fun x ->
    seq {
        for a in 1 .. x do
            for b in 1 .. (x / a) do
                let c = x - (a * b)
                if c <> 0 then yield (a, b, c)
    }
|> Seq.length
|> printfn "%d"
