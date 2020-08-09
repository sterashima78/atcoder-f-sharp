stdin.ReadLine().ToCharArray()
|> Array.groupBy id
|> Array.filter (fun (_, x) -> Array.length x = 2)
|> Array.length
|> fun x -> if x = 2 then "Yes" else "No"
|> printfn "%s"
