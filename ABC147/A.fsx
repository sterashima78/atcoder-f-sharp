stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.reduce (+)
|> (fun x -> if x >= 22 then "bust" else "win")
|> printfn "%s"
