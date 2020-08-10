stdin.ReadLine().Split(" ")
|> Array.map float
|> Array.reduce (/)
|> printfn "%f"
