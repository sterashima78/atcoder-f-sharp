let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int64

let choice ok ng bool = if bool then ok else ng

readIntArray ()
|> fun [| x; y; z |] -> x <= y * z
|> choice "Yes" "No"
|> printfn "%s"
