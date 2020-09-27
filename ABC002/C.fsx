let readFloatArray _ =
    stdin.ReadLine().Split(" ") |> Array.map float


()
|> readFloatArray
|> fun [| x; y; a0; b0; c0; d0 |] ->
    let a = a0 - x
    let b = b0 - y
    let c = c0 - x
    let d = d0 - y
    a * d - b * c |> abs |> (/) <| 2.0
|> printf "%f"
