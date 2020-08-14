stdin.ReadLine().Split(" ")
|> Array.map (fun x -> x.ToCharArray() |> Array.head)
|> Array.map System.Char.ToUpper
|> System.String
|> printfn "%s"
