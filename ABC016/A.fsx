let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let choice ok ng bool = if bool then ok else ng

readIntArray ()
|> Array.reduce (%)
|> (=) 0
|> choice "YES" "NO"
|> printfn "%s"
