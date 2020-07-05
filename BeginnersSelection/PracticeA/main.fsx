Array.append [| stdin.ReadLine() |] (stdin.ReadLine().Split(' '))
|> Array.map int
|> Array.reduce (+)
|> printfn "%d %s" <| stdin.ReadLine()
