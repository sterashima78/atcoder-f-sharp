stdin.ReadLine().ToCharArray()
|> Array.zip
<| stdin.ReadLine().ToCharArray()
|> Array.map (fun (a, b) -> if a = b then 1 else 0)
|> Array.reduce (+)
|> printfn "%d"
