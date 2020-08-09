stdin.ReadLine().Split(" ")
|> Array.map int
|> fun x ->
    x
    |> Array.reduce (-)
    |> System.Math.Abs
    |> fun i ->
        if i % 2 = 0 then
            (Array.max x - (i / 2))
            |> System.Math.Abs
            |> string
        else
            "IMPOSSIBLE"

|> printfn "%s"
