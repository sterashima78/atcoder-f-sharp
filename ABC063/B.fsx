let readCharArray _ = stdin.ReadLine().ToCharArray()
let choice ok ng bool = if bool then ok else ng

()
|> readCharArray
|> fun x -> x.Length = (x |> Array.groupBy id |> Array.length)
|> choice "yes" "no"
|> printfn "%s"
