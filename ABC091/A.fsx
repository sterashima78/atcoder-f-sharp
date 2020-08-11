stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| x; y; z |] -> if x + y < z then "No" else "Yes"
|> printfn "%s"
