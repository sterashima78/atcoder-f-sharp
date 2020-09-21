let readInt _ = stdin.ReadLine() |> int

()
|> readInt
|> fun x ->
    [| 1 .. (x |> float |> sqrt |> int) |]
    |> Array.map (fun i ->
        let rest = x % i
        let width = x / i
        i - width |> abs |> (+) rest)
    |> Array.min
    |> printfn "%d"
