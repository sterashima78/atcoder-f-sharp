stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.reduce (*)
|> fun x -> if x % 2 = 0 then "Even" else "Odd"
|> printfn "%s"
