let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

stdin.ReadLine()
|> readIntArray
|> fun x ->
    Array.concat [ [| 10000000L |]
                   x
                   [| 10000000L |] ]
|> fun arr ->
    arr
    |> Array.tail
    |> Array.zip
    <| Array.take (arr.Length - 1) arr
    |> Array.sumBy (fun (a, b) -> min a b)
    |> printfn "%d"
