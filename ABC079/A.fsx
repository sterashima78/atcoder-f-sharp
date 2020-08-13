stdin.ReadLine().ToCharArray()
|> fun a ->
    let x =
        Array.take 3 a |> Array.groupBy id |> Array.length

    let y =
        Array.rev a
        |> Array.take 3
        |> Array.groupBy id
        |> Array.length

    if x = 1 || y = 1 then "Yes" else "No"
|> printfn "%s"
