stdin.ReadLine().ToCharArray()
|> Array.map (fun x -> if x = '+' then 1 else -1)
|> Array.reduce (+)
|> printfn "%d"
