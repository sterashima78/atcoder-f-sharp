stdin.ReadLine().Split(" ")
|> Array.map float
|> Array.reduce (/)
|> System.Math.Ceiling
|> int
|> printfn "%d"
