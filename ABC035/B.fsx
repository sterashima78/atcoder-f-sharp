let readInt _ = stdin.ReadLine() |> int
let readCharArray _ = stdin.ReadLine().ToCharArray()

let rec calcCoord (x, y, question) rest =
    match rest with
    | [] -> (x, y, question)
    | 'L' :: xx -> calcCoord (x - 1, y, question) xx
    | 'R' :: xx -> calcCoord (x + 1, y, question) xx
    | 'U' :: xx -> calcCoord (x, y + 1, question) xx
    | 'D' :: xx -> calcCoord (x, y - 1, question) xx
    | _ :: xx -> calcCoord (x, y, question + 1) xx

let solve flag (x, y, question) =
    let dist = (abs x) + (abs y)
    if flag = 1 then dist + question
    elif dist > question then dist - question
    else (question - dist) % 2

()
|> readCharArray
|> Array.toList
|> calcCoord (0, 0, 0)
|> solve (readInt ())
|> printfn "%d"
