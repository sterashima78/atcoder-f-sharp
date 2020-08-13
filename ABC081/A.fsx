stdin.ReadLine().ToCharArray()
|> Array.map string
|> Array.map int
|> Array.reduce (+)
|> printfn "%d"
