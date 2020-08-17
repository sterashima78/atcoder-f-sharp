let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let choice ok ng bool = if bool then ok else ng

readIntArray ()

readIntArray ()
|> fun x ->
    x
    |> Array.filter (fun y -> y % 2 = 1 || y % 3 = 0 || y % 5 = 0)
    |> Array.length
    |> (=)
    <| (x |> Array.length)
|> choice "APPROVED" "DENIED"
|> printfn "%s"
