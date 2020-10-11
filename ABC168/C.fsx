let readFloatArray _ =
    stdin.ReadLine().Split(" ") |> Array.map double

()
|> readFloatArray
|> fun [| a; b; h; m |] ->
    let rad =
        System.Math.PI
        * 2.0
        * (h / 12.0 + m / 60.0 / 12.0 - m / 60.0)

    let raq =
        (a * a + b * b)
        - (double 2 * a * b)
        * (rad |> float |> System.Math.Cos |> double)

    raq |> sqrt
|> printfn "%f"
