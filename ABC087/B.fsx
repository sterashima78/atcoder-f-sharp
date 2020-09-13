let readInt _ = stdin.ReadLine() |> int


(readInt (), readInt (), readInt (), readInt ())
|> fun (a, b, c, x) ->
    seq {
        for c500 in [ 0 .. a ] do
            for c100 in [ 0 .. b ] do
                for c50 in [ 0 .. c ] do
                    yield c500 * 500 + c100 * 100 + c50 * 50
    }
    |> Seq.filter ((=) x)
    |> Seq.length
    |> printfn "%d"
