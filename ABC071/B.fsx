let readCharArray _ = stdin.ReadLine().ToCharArray()
let uniq a = a |> Array.groupBy id |> Array.map fst

()
|> readCharArray
|> uniq
|> Array.sort
|> fun x ->
    if x.[0] <> 'a' then
        "a"
    elif x.Length = 26 then
        "None"
    else
        let y =
            Array.zip x.[0..x.Length - 2] x.[1..x.Length - 1]
            |> Array.filter (fun (a, b) -> (int b) - (int a) <> 1)

        if y.Length = 0
        then "z"
        else y.[0] |> fst |> int |> (+) 1 |> char |> string
|> printfn "%s"
