let readCharArray _ = stdin.ReadLine().ToCharArray()

let x = readCharArray ()
let y = readCharArray ()

(if x.Length = y.Length then Array.zip x y else Array.zip x (Array.append y [| ' ' |]))
|> Array.collect (fun (x, y) -> [| x; y |])
|> System.String
|> fun x -> x.Trim()
|> printfn "%s"
