let readInt _ = stdin.ReadLine() |> int

let d = Map []

let rec solve d (arr: int []) current =
    let c = current - 1
    let next = arr.[c]
    if next = 2 then
        d |> Map.count |> (+) 1
    elif d |> Map.containsKey next then
        -1
    else
        let newMap = d |> Map.add next next
        solve newMap arr next


()
|> readInt
|> fun x -> [| 1 .. x |]
|> Array.map readInt
|> solve d
<| 1
|> printfn "%d"
