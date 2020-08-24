let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let choice ok ng bool = if bool then ok else ng

stdin.ReadLine()

readIntArray ()
|> fun x -> x |> Array.sort |> Array.zip x
|> Array.filter (fun (a, b) -> a <> b)
|> Array.length
|> ((>=) 2)
|> choice "YES" "NO"
|> printfn "%s"
