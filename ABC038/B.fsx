let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| h1; w1 |] ->
    let [| h2; w2 |] = () |> readIntArray
    if h1 = h2 || h1 = w2 || w1 = h2 || w1 = w2 then "YES" else "NO"
    |> printfn "%s"
