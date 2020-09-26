let readCharArray _ = stdin.ReadLine().ToCharArray()

()
|> readCharArray
|> Array.fold (fun (b, w, i) c -> if i % 2 |> string |> char |> (=) c then (b + 1, w, i + 1) else (b, w + 1, i + 1))
       (0, 0, 0)
|> fun (b, w, _) -> min b w
|> printfn "%d"
