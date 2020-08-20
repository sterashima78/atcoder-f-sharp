stdin.ReadLine()

stdin.ReadLine().Split(" ")
|> Array.map (fun x -> x.ToCharArray())
|> fun x -> Array.zip x.[0] x.[1]
|> Array.map (fun (a, b) -> [| a; b |] |> System.String)
|> String.concat ""
|> printfn "%s"
