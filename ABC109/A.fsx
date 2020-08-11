stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.exists (fun x -> x = 2)
|> fun x -> if x then "No" else "Yes"
|> printf "%s"
