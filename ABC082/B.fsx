let readCharArray _ = stdin.ReadLine().ToCharArray()
let choice ok ng bool = if bool then ok else ng

readCharArray ()
|> Array.sort
|> System.String
|> fun x ->
    readCharArray ()
    |> Array.sortDescending
    |> System.String
    |> ((<) x)
    |> choice "Yes" "No"
    |> printfn "%s"
