stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.sort
|> Array.zip [| 1; 1; 10 |]
|> Array.map (fun (a, b) -> a * b)
|> Array.reduce (+)
|> printfn "%d"
