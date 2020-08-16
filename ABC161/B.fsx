let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let choice ok ng bool = if bool then ok else ng

readIntArray ()
|> fun [| _; m |] ->
    let x = readIntArray ()
    let all = x |> Array.reduce (+)
    x
    |> Array.sortDescending
    |> Array.take m
    |> Array.rev
    |> Array.head
    |> fun x -> x * 4 * m >= all
|> choice "Yes" "No"
|> printfn "%s"
