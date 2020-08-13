stdin.ReadLine().Split(" ")
|> Array.map char
|> System.String
|> int
|> fun x -> if x % 4 = 0 then "YES" else "NO"
|> printfn "%s"
