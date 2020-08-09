stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.map (fun x -> if x >= 10 then 0 else x)
|> Array.reduce (*)
|> (fun x -> if x = 0 then -1 else x)
|> printfn "%d"
