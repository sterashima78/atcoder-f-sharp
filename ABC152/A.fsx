stdin.ReadLine().Split(" ")
|> Array.countBy id
|> Array.length
|> (fun x -> if x = 1 then "Yes" else "No")
|> printfn "%s"
