stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b; c; d |] ->
    let x = a + b
    let y = c + d
    if x = y then "Balanced"
    else if x > y then "Left"
    else "Right"
|> printfn "%s"
