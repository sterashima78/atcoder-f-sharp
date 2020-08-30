let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int64

let rec solve arr rest r d before =
    match rest with
    | 0 -> arr
    | i ->
        let item: int64 = r * before - d
        let newArr = Array.append arr [| item |]
        solve newArr (i - 1) r d item

()
|> readIntArray
|> fun [| r; d; x |] -> solve [||] 10 r d x
|> Array.map string
|> String.concat "\n"
|> printfn "%s"
