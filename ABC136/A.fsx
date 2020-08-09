stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.reduce (-)
|> (fun x -> if x >= 0 then 0 else x * (-1))
|> printfn "%d"
