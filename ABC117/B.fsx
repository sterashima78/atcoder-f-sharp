let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let choice ok ng bool = if bool then ok else ng

stdin.ReadLine()

()
|> readIntArray
|> Array.sortDescending
|> fun x -> (x |> Array.head) < (x |> Array.tail |> Array.sum)
|> choice "Yes" "No"
|> printfn "%s"
