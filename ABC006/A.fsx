let readInt () = stdin.ReadLine() |> int
let choice ok ng bool = if bool then ok else ng

readInt ()
|> (%)
<| 3
|> (=) 0
|> choice "YES" "NO"
|> printfn "%s"
