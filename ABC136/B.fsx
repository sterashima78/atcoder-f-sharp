let readInt () = stdin.ReadLine() |> int

let next x = (10.0 ** (float x) |> int)

let rec solve c v =
    v
    |> string
    |> String.length
    |> fun x ->
        if x = 1 then
            c + v
        else if x % 2 = 0 then
            x
            - 1
            |> next
            |> fun z -> solve c (z - 1)
        else
            x
            - 1
            |> next
            |> fun z -> solve (c + v - z + 1) (z - 1)

() |> readInt |> solve 0 |> printfn "%d"
