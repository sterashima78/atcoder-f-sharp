Array.concat
    [| [| stdin.ReadLine() |]
       stdin.ReadLine().Split(' ') |]
|> Array.map int
|> Array.reduce (+)
|> printfn "%d %s"
|> (fun p -> p (stdin.ReadLine()))
