stdin.ReadLine().ToCharArray()
|> Array.exists (fun x -> x = '9')
|> fun x -> if x then "Yes" else "No"
|> printfn "%s"
