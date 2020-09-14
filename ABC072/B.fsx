let readCharArray _ = stdin.ReadLine().ToCharArray()

()
|> readCharArray
|> Array.indexed
|> Array.filter (fun (i, _) -> i % 2 = 0)
|> Array.map (fun (_, c) -> c)
|> System.String
|> printfn "%s"
