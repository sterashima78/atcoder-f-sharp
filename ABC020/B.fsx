stdin.ReadLine().Split(" ")
|> String.concat ""
|> int
|> (*) 2
|> printfn "%d"
