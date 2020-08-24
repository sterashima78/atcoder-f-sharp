let readCharArray () = stdin.ReadLine().ToCharArray()
let choice ok ng bool = if bool then ok else ng

readCharArray ()
|> Array.map string
|> Array.map int
|> Array.sum
|> (%)
<| 9
|> (=) 0
|> choice "Yes" "No"
|> printfn "%s"
