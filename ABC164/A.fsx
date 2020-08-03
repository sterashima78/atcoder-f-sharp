stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.reduce (-)
|> (fun x -> if x <= 0 then "unsafe" else "safe")
|> printfn "%s"
