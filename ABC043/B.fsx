let readCharArray _ = stdin.ReadLine().ToCharArray()

let rec solve ans q =
    match q with
    | 'B' :: xx -> if (ans |> List.isEmpty) then solve [] xx else ans |> List.tail |> solve <| xx
    | x :: xx -> solve (x :: ans) xx
    | _ -> ans |> List.rev |> List.toArray


()
|> readCharArray
|> Array.toList
|> solve []
|> System.String
|> printfn "%s"
