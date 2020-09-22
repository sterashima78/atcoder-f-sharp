let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| x1; y1; x2; y2 |] ->
    let x = x2 - x1
    let y = y2 - y1
    let x3 = x2 - y
    let y3 = y2 + x
    let x4 = x1 - y
    let y4 = y1 + x
    printfn "%d %d %d %d" x3 y3 x4 y4
