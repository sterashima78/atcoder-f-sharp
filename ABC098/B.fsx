let readCharArray () = stdin.ReadLine().ToCharArray()

stdin.ReadLine()

let uniq arr = arr |> Array.groupBy id |> Array.map fst

let countSameElement arr1 arr2 =
    let x = arr1 |> uniq
    arr2
    |> uniq
    |> Array.filter (fun z -> x |> Array.contains z)
    |> Array.length


()
|> readCharArray
|> fun x ->
    [ 0 .. (x.Length - 1) ]
    |> List.map (fun i -> countSameElement (x.[0..i]) (x.[(i + 1)..(x.Length - 1)]))
    |> List.max
    |> printfn "%d"
