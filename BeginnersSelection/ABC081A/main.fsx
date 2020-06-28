stdin.ReadLine().ToCharArray()
|> Array.map (string >> int)
|> Array.reduce (+)
|> printfn "%d"
