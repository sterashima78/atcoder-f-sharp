let readCharArray () = stdin.ReadLine().ToCharArray()

readCharArray ()
|> Array.groupBy id
|> Array.length
|> fun x -> if x = 1 then "SAME" else "DIFFERENT"
|> printfn "%s"
