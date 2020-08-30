let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

stdin.ReadLine()

()
|> readIntArray
|> fun arr ->
    let iMax = arr |> Array.length |> (-) <| 1
    [ 0 .. iMax ]
    |> List.map (fun x ->
        (Array.sum arr.[0..x] - Array.sum arr.[x + 1..iMax])
        |> abs)
    |> List.min
    |> printfn "%d"
