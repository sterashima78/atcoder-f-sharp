let readCharArray () = stdin.ReadLine().ToCharArray()
let choice ok ng bool = if bool then ok else ng

readCharArray ()
|> Array.indexed
|> Array.exists (fun (i, c) -> i % 2 = 0 && c = 'L' || i % 2 = 1 && c = 'R')
|> choice "No" "Yes"
|> printfn "%s"
