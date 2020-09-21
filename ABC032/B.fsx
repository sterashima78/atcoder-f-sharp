let readCharArray _ = stdin.ReadLine().ToCharArray()
let readInt _ = stdin.ReadLine() |> int
let uniqArray x = x |> Array.groupBy id |> Array.map fst

let rec solve len ans query =
    if (query |> List.length) >= len then
        let str =
            query
            |> List.take len
            |> List.toArray
            |> System.String

        solve len (str :: ans) (query |> List.tail)
    else
        ans |> List.toArray |> uniqArray |> Array.length

()
|> readCharArray
|> Array.toList
|> solve (readInt ()) []
|> printfn "%d"
