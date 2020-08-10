stdin.ReadLine().Split(" ")
|> Array.map int
|> (fun [| a; b |] -> if b % a = 0 then a + b else b - a)
|> printfn "%d"
