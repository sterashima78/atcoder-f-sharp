let readInt _ = stdin.ReadLine() |> int

readInt ()
|> fun x ->
    seq { x .. -1 .. 1 }
    |> Seq.filter (fun a ->
        a
        |> float
        |> System.Math.Sqrt
        |> int
        |> pown
        <| 2
        |> (=) a)
    |> Seq.head
|> printfn "%d"
