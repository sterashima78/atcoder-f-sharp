stdin.ReadLine().Split(" ")
|> Array.map (fun x -> x.ToCharArray() |> Array.head)
|> System.String
|> printfn "%s"
