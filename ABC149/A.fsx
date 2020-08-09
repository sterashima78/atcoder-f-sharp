stdin.ReadLine().Split(" ")
|> Array.rev
|> String.concat ""
|> printfn "%s"
