stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.sort
|> Array.rev
|> Array.reduce (-)
|> fun x -> if x = 0 then "Yes" else "No"
|> printfn "%s"
