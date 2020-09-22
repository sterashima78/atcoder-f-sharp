let readInt _ = stdin.ReadLine() |> int
let uniqList x = x |> List.groupBy id |> List.map fst

let rec toDivisor ans count n =
    if n % 2 = 0 && n / 2 < count then ans |> uniqList
    elif n % 2 = 1 && (n / 2 + 1) < count then ans |> uniqList
    elif n % count = 0 && count * count <> n then toDivisor (count :: (n / count) :: ans) (count + 1) n
    elif n % count = 0 then (count :: ans)
    else toDivisor ans (count + 1) n

let choice ok ng bool = if bool then ok else ng

()
|> readInt
|> fun x ->
    [ 1 .. 2 .. x ]
    |> List.map (toDivisor [] 1)
    |> List.filter (fun x -> x |> List.length |> (=) 8)
    |> List.length
    |> printfn "%d"
