let readCharArray _ = stdin.ReadLine().ToCharArray()
let choice ok ng bool = if bool then ok else ng

readCharArray ()
|> Array.groupBy id
|> Array.map snd
|> Array.map Array.length
|> Array.map (fun x -> x % 2 = 0)
|> Array.reduce (&&)
|> choice "Yes" "No"
|> printfn "%s"
