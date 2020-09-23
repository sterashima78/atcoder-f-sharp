let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let toCheckpoint checkpoints [| x; y |] =
    checkpoints
    |> Array.minBy (fun (_, [| a; b |]) -> abs (x - a) + abs (y - b))
    |> fst
    |> (+) 1
    |> string

()
|> readIntArray
|> fun [| n; m |] ->
    let students = [| 1 .. n |] |> Array.map readIntArray

    let checkpoints =
        [| 1 .. m |]
        |> Array.map readIntArray
        |> Array.indexed

    students
    |> Array.map (toCheckpoint checkpoints)
    |> String.concat "\n"
    |> printfn "%s"
