let readCharArray () = stdin.ReadLine().ToCharArray()

let rec solve ans query =
    match (ans, query) with
    | ([], x :: xx) -> solve [ (x, 1) ] xx
    | ((a, i) :: aa, x :: xx) -> if x = a then solve ((a, i + 1) :: aa) xx else solve ((x, 1) :: (a, i) :: aa) xx
    | (a, []) ->
        a
        |> List.rev
        |> List.map (fun (a, i) -> sprintf "%c%d" a i)
        |> String.concat ""


()
|> readCharArray
|> Array.toList
|> solve []
|> printfn "%s"
