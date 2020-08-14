stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.sort
|> fun [| x; y; z |] -> if x = 5 && y = 5 && z = 7 then "YES" else "NO"
|> printfn "%s"
