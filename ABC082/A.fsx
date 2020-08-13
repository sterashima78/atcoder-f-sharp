stdin.ReadLine().Split(" ")
|> Array.map float
|> Array.average
|> System.Math.Ceiling
|> int
|> printfn "%d"
