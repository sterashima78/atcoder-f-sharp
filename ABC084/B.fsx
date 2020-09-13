let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| a; b |] ->
    let zip = stdin.ReadLine().Split("-")
    match zip with
    | [| x; y |] -> if x.Length = a && y.Length = b then "Yes" else "No"
    | _ -> "No"
|> printfn "%s"
