let readCharArray _ = stdin.ReadLine().ToCharArray()

()
|> readCharArray
|> fun x ->
    (x.[0] |> string)
    + (x.Length |> (-) <| 2 |> string)
    + (x.[x.Length - 1] |> string)
|> printfn "%s"
