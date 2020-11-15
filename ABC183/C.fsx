let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

let rec dist e =
    function
    | [] -> [ [ e ] ]
    | x :: xs ->
        (e :: x :: xs)
        :: [ for ys in dist e xs -> x :: ys ]

let rec permute =
    function
    | [] -> [ [] ]
    | x :: xs -> List.collect (dist x) (permute xs)

let rec solve (times: int64 array array) limit current before rest =
    if limit < current then
        current
    else
        match rest with
        | x :: xx ->
            if before < 0
            then solve times limit current x xx
            else solve times limit (current + times.[before - 1].[x - 1]) x xx
        | [] -> current

()
|> readIntArray
|> fun [| n; k |] ->
    let times =
        [| 0 .. (int n) - 1 |] |> Array.map readIntArray

    [ 2 .. int n ]
    |> permute
    |> List.map (fun x ->
        1
        :: x
        |> List.rev
        |> List.append [ 1 ]
        |> solve times k 0L -1)
    |> List.filter ((=) k)
    |> List.length
|> printfn "%A"
