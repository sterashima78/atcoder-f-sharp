stdin.ReadLine()
|> float
|> (fun x -> if x % 2.0 = 0.0 then 0.5000000 else System.Math.Ceiling(x / 2.0) / x)
|> printfn "%f"
