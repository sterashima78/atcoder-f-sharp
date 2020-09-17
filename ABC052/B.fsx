let readCharArray _ = stdin.ReadLine().ToCharArray()

stdin.ReadLine()

()
|> readCharArray
|> Array.map (fun x -> if x = 'I' then 1 else -1)
|> Array.mapFold (fun state num -> (state, state + num)) 0
|> fun (a, b) -> Array.append a [| b |]
|> Array.max
|> printfn "%d"
