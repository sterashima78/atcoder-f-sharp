let readCharArray () = stdin.ReadLine().ToCharArray()

()
|> readCharArray
|> Array.indexed
|> Array.map (fun (index, c) -> if index = 0 then c |> System.Char.ToUpper else c |> System.Char.ToLower)
|> System.String
|> printfn "%s"
