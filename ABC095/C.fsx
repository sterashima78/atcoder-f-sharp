let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec solve s a b ab (aRest, bRest) =
    if aRest > 0 && bRest > 0
    then solve (s + ab) a b ab (aRest - 1, bRest - 1)
    elif aRest > 0
    then solve (s + a) a b ab (aRest - 1, bRest)
    elif bRest > 0
    then solve (s + b) a b ab (aRest, bRest - 1)
    else s

()
|> readIntArray
|> fun [| a; b; c; x; y |] ->
    let aPrice = if a < c * 2 then a else c * 2
    let bPrice = if b < c * 2 then b else c * 2
    let abPrice = if a + b < c * 2 then a + b else c * 2
    solve 0 aPrice bPrice abPrice (x, y)
    |> printfn "%d"
