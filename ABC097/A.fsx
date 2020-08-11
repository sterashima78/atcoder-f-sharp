stdin.ReadLine().Split(" ")
|> Array.map int
|> fun x ->
    let d = x |> Array.rev |> Array.head
    x
    |> Array.take 3
    |> fun [| a; b; c |] ->
        if (System.Math.Abs(c - b)
            <= d
            && System.Math.Abs(b - a) <= d)
           || (System.Math.Abs(a - c) <= d) then
            "Yes"
        else
            "No"
        |> printfn "%s"
