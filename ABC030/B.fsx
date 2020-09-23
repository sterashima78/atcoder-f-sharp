let readFloatArray _ =
    stdin.ReadLine().Split(" ") |> Array.map float

()
|> readFloatArray
|> fun [| n; m |] ->
    let h = n % 12.0
    let d = m * 6.0 - (h * 30.0 + m * 0.5) |> abs
    if d > 180.0 then 360.0 - d else d
|> printfn "%f"
