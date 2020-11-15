let readFloatArray _ =
    stdin.ReadLine().Split(" ") |> Array.map double

()
|> readFloatArray
|> fun [| sx; sy; gx; gy |] -> (gx - sx) / (gy + sy) * sy + sx
|> printfn "%A"
