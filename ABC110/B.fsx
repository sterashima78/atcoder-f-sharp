let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let choice ok ng bool = if bool then ok else ng

()
|> readIntArray
|> fun [| _; _; x; y |] ->
    let xMax =
        ()
        |> readIntArray
        |> Array.sortDescending
        |> Array.head

    let yMin =
        () |> readIntArray |> Array.sort |> Array.head

    xMax < yMin && x < y && xMax < y && x < yMin
|> choice "No War" "War"
|> printfn "%s"
