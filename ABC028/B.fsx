let readCharArray _ = stdin.ReadLine().ToCharArray()

()
|> readCharArray
|> Array.append [| 'A'
                   'B'
                   'C'
                   'D'
                   'E'
                   'F' |]
|> Array.groupBy id
|> Array.sortBy fst
|> Array.map (fun x -> x |> snd |> Array.length |> (-) <| 1 |> string)
|> String.concat " "
|> printfn "%s"
