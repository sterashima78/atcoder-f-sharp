let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec solve count arr =
    let x =
        arr
        |> Array.filter (fun x -> (x % 2) <> 0)
        |> Array.length

    if x = 0
    then solve (count + 1) (arr |> Array.map (fun x -> x / 2))
    else count

stdin.ReadLine()

() |> readIntArray |> solve 0 |> printfn "%d"
