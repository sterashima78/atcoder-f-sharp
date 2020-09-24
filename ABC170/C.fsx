let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| x; num |] ->
    if num = 0 then
        stdin.ReadLine() |> ignore
        x
    else
        ()
        |> readIntArray
        |> fun a ->
            let max = a |> Array.max
            let min = a |> Array.min
            [| min - 1 .. max + 1 |]
            |> Array.filter (fun z ->
                a
                |> Array.tryFind (fun a -> a = z)
                |> Option.isNone)
            |> Array.sortBy (fun z -> abs (z - x))
            |> Array.head
|> printfn "%d"
