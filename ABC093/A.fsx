stdin.ReadLine().ToCharArray()
|> Array.groupBy id
|> Array.length
|> fun x -> if x = 3 then "Yes" else "No"
|> printfn "%s"
