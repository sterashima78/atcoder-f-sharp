let readCharArray () = stdin.ReadLine().ToCharArray()

let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let readInt () = stdin.ReadLine() |> int

let rec solve str switch =
    match switch with
    | [] -> str
    | (r, l) :: xx ->
        let len = str |> Array.length
        if r = 1 && len = l then
            str |> Array.rev |> solve <| xx
        else if r = 1 then
            str
            |> Array.take l
            |> Array.rev
            |> Array.append
            <| str.[l..]
            |> solve
            <| xx
        else if l = len then
            str.[(r - 1)..]
            |> Array.rev
            |> Array.append str.[0..(r - 2)]
            |> solve
            <| xx
        else
            str.[(r - 1)..(l - 1)]
            |> Array.rev
            |> Array.append str.[0..(r - 2)]
            |> Array.append
            <| str.[l..]
            |> solve
            <| xx


()
|> readCharArray
|> fun x ->
    let i = readInt ()
    [ 1 .. i ]
    |> List.map (fun _ -> () |> readIntArray |> (fun [| r; l |] -> (r, l)))
    |> solve x
|> System.String
|> printfn "%s"
