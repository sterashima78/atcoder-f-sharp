stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.reduce (+)
|> fun x -> if x >= 10 then "error" else x |> string
|> printfn "%s"
