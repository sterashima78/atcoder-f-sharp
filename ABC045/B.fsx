let readCharArray _ = stdin.ReadLine().ToCharArray()

let rec solve next (a, b, c) =
    match next with
    | 'a' ->
        if a |> Array.length |> (=) 0 then
            "A"
        else
            let n = a |> Array.head
            solve n (a |> Array.tail, b, c)
    | 'b' ->
        if b |> Array.length |> (=) 0 then
            "B"
        else
            let n = b |> Array.head
            solve n (a, b |> Array.tail, c)
    | _ ->
        if c |> Array.length |> (=) 0 then
            "C"
        else
            let n = c |> Array.head
            solve n (a, b, c |> Array.tail)

(readCharArray (), readCharArray (), readCharArray ())
|> solve 'a'
|> printfn "%s"
