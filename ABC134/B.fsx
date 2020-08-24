let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| n; d |] ->
    let v = d * 2 + 1
    if n % v = 0 then n / v else n / v + 1
    |> printfn "%d"
