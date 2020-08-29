let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| n; m |] ->
    let arr = Array.init n id
    [| 1 .. m |]
    |> Array.fold (fun a _ ->
        ()
        |> readIntArray
        |> fun [| x1; y1 |] ->
            let x = x1 - 1
            let y = y1 - 1
            if x < y then
                Array.concat [| Array.sub a 0 y
                                Array.sub a x 1
                                Array.sub a y (n - y1) |]
            else
                Array.concat [| Array.sub a 0 x
                                Array.sub a y 1
                                Array.sub a x (n - x1) |]

        ) arr
    |> Array.countBy id
    |> Array.maxBy (fun (_, i) -> i)
    |> fun (_, i) -> i
    |> printfn "%d"
