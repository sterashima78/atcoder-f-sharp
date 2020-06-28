stdin.ReadLine()

let isEvenAll arr =
    arr
    |> Array.filter (fun x -> x % 2 = 0)
    |> Array.length
    |> fun x -> x = Array.length arr

let rec solve tuple =
    match tuple with
    | (arr, count) when isEvenAll arr -> solve (arr |> Array.map (fun x -> x / 2), count + 1)
    | (_, count) -> count

stdin.ReadLine().Split(" ")
|> Array.map int
|> fun a -> (a, 0)
|> solve
|> printfn "%d"
