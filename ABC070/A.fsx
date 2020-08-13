stdin.ReadLine()
|> fun x ->
    let y =
        x.ToCharArray() |> Array.rev |> System.String

    if x = y then "Yes" else "No"
|> printfn "%s"
