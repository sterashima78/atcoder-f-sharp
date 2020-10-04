let readCharArray _ = stdin.ReadLine().ToCharArray()
let readInt _ = stdin.ReadLine() |> int64

let rec solve index count (arr: char []) =
    if arr.[0] = '1' && count < index
    then solve index (count + 1L) (arr |> Array.tail)
    elif arr.[0] = '1' && index = count
    then "1"
    else arr.[0] |> string

()
|> readCharArray
|> fun c ->
    let i = () |> readInt
    solve i 1L c
|> printfn "%s"
