let readArray _ = stdin.ReadLine().Split(" ")
let choice ok ng bool = if bool then ok else ng

stdin.ReadLine()

()
|> readArray
|> Array.groupBy id
|> Array.length
|> (=) 3
|> choice "Three" "Four"
|> printfn "%s"
