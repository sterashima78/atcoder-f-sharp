let readCharArray () = stdin.ReadLine().ToCharArray()

readCharArray ()
|> Array.map string
|> Array.map int
|> Array.reduce (+)
|> printfn "%d"
