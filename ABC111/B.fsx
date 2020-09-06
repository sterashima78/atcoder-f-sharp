let readCharArray () = stdin.ReadLine().ToCharArray()

()
|> readCharArray
|> fun arr ->
    let a =
        [| arr.[0]; arr.[0]; arr.[0] |]
        |> System.String
        |> int

    let b = arr |> System.String |> int
    if a >= b then
        a
    else
        let n = arr.[0] |> string |> int |> (+) 1
        n * 100 + n * 10 + n
|> printfn "%d"
