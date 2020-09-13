let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let readInt () = stdin.ReadLine() |> int

()
|> readIntArray
|> fun [| n; x |] ->
    [| 1 .. n |]
    |> Array.map (fun _ -> () |> readInt)
    |> fun y ->
        let rest = y |> Array.sum |> (-) x
        y
        |> Array.min
        |> (/) rest
        |> (+)
        <| Array.length y
    |> printfn "%d"
