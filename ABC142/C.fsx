stdin.ReadLine()
stdin.ReadLine().Split(" ") 
|> Array.map int
|> Array.indexed
|> Array.sortBy (fun (_, i)-> i)
|> Array.map (fun (x, _)-> x + 1 |> string)
|> String.concat " "
|> printfn "%s"
