let readInt _ = stdin.ReadLine() |> int

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readInt
|> readIntArray
|> fun x ->
    let sum = x |> Array.sum
    readInt ()
    |> fun x -> [| 1 .. x |]
    |> Array.map readIntArray
    |> Array.map (fun [| p; z |] -> sum - x.[p - 1] + z)
    |> Array.map string
    |> String.concat "\n"
    |> printfn "%s"
