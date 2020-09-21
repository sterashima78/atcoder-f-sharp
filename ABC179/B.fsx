let readInt _ = stdin.ReadLine() |> int

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec solve count list =
    match (count, list) with
    | (3, _) -> "Yes"
    | (c, [| a; b |] :: xx) -> if a = b then solve (c + 1) xx else solve 0 xx
    | (_, []) -> "No"

()
|> readInt
|> fun x ->
    [ 1 .. x ]
    |> List.map readIntArray
    |> solve 0
    |> printfn "%s"
