let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| a; b; k |] ->
    seq { 100 .. -1 .. 1 }
    |> Seq.filter (fun x -> a % x = 0 && b % x = 0)
    |> Seq.take k
    |> Seq.rev
    |> Seq.head
|> printfn "%d"
