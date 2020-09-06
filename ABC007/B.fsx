let readCharArray () = stdin.ReadLine().ToCharArray()

()
|> readCharArray
|> fun a ->
    match a with
    | [| 'a' |] -> "-1"
    | [| x |] -> x |> int |> (-) <| 1 |> char |> string
    | x ->
        x
        |> Array.rev
        |> Array.tail
        |> Array.rev
        |> System.String
    | _ -> "-1"
|> printfn "%s"
