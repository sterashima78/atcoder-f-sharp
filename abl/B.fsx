let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

()
|> readIntArray
|> fun [| l1; r1; l2; r2 |] ->
    if l1 <= l2 && l2 <= r1 then "Yes"
    elif l2 <= l1 && l1 <= r2 then "Yes"
    else "No"
|> printfn "%s"
