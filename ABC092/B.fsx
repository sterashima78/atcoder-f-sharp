let readInt _ = stdin.ReadLine() |> int

let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readInt
|> fun n ->
    let [| d; rest |] = readIntArray ()
    [| 1 .. n |]
    |> Array.map readInt
    |> Array.map (fun x -> if d % x = 0 then d / x else d / x + 1)
    |> Array.sum
    |> (+) rest
|> printfn "%d"
