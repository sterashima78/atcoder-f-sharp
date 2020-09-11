let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec count c q =
    if q % 100 = 0 then count (c + 1) (q / 100) else c

readIntArray ()
|> fun [| d; n |] ->
    Seq.initInfinite ((+) 1)
    |> Seq.filter (fun x -> (count 0 x) = d)
    |> Seq.skip (n - 1)
    |> Seq.head
    |> printfn "%d"
