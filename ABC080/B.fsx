let readInt _ = stdin.ReadLine() |> int
let choice ok ng bool = if bool then ok else ng

()
|> readInt
|> fun x ->
    x
    |> string
    |> fun x -> x.ToCharArray()
    |> Array.map string
    |> Array.map int
    |> Array.sum
    |> (%) x
    |> (=) 0
    |> choice "Yes" "No"
    |> printfn "%s"
