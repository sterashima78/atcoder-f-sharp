let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int64

readIntArray ()
|> fun [| x; b; c |] ->
    let a = x |> System.Math.Abs
    if b - a / c < 0L then a - b * c
    else if (b - a / c) % 2L = 1L then (a % c) - c |> System.Math.Abs
    else (a % c) |> System.Math.Abs
|> printfn "%d"
