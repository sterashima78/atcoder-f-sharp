stdin.ReadLine().ToCharArray()
|> Array.exists (fun x -> x = '7')
|> (fun x -> if x then "Yes" else "No")
|> printfn "%s"
