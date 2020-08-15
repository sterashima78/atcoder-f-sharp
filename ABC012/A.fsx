let readArray () = stdin.ReadLine().Split(" ")

readArray ()
|> Array.rev
|> String.concat " "
|> printfn "%s"
