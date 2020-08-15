let readCharArray () = stdin.ReadLine().ToCharArray()

readCharArray ()
|> Array.rev
|> Array.head
|> fun x -> if x = 'T' then "YES" else "NO"
|> printfn "%s"
