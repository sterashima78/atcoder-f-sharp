let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

stdin.ReadLine()

readIntArray ()
|> fun a ->
    let n = a |> Array.length
    [ for x in 1 .. (n - 1) do
        for y in (x + 1) .. n -> a.[x - 1] * a.[y - 1] ]
    |> List.sum
    |> printfn "%d"
