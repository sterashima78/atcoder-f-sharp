stdin.ReadLine().ToCharArray()
|> Array.countBy id
|> Array.length
|> (fun x -> if x = 1 then "No" else "Yes")
|> printfn "%s"
