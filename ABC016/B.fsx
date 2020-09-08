let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| a; b; c |] ->
    if a + b <> a - b && a + b = c then "+"
    else if a + b <> a - b && a - b = c then "-"
    else if a + b = a - b && a - b = c then "?"
    else "!"
    |> printfn "%s"
