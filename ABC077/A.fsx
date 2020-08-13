stdin.ReadLine().ToCharArray()
|> Array.rev
|> System.String
|> fun x -> if x = (stdin.ReadLine()) then "YES" else "NO"
|> printfn "%s"
