let readInt () = stdin.ReadLine() |> int
let choice ok ng bool = if bool then ok else ng

()
|> readInt
|> fun x ->
    x
    |> string
    |> (fun f -> f.ToCharArray())
    |> Array.map string
    |> Array.sumBy int
    |> (%) x
    |> (=) 0
|> choice "Yes" "No"
|> printfn "%s"
