stdin.ReadLine().ToCharArray()
|> Array.map (fun x -> if x = 'o' then 100 else 0)
|> Array.fold (+) 700
|> printfn "%d"
