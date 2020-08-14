stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.chunkBySize 2
|> Array.map (Array.reduce (*))
|> fun [| x; y |] -> if x >= y then x else y
|> printfn "%d"
