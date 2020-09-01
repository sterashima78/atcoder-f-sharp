let readCharArray () = stdin.ReadLine().ToCharArray()

let rec solve min list =
    match list with
    | x :: y :: z :: xx ->
        let diff =
            [| x; y; z |]
            |> System.String
            |> int
            |> (-) 753
            |> abs

        if diff > min then solve min (y :: z :: xx) else solve diff (y :: z :: xx)
    | _ -> min

()
|> readCharArray
|> Array.toList
|> solve 753
|> printfn "%d"
