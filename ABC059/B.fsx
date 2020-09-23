let readCharArray _ = stdin.ReadLine().ToCharArray()

let a = readCharArray ()
let b = readCharArray ()

let rec cmp a b =
    let aLen = a |> Array.length
    let bLen = b |> Array.length
    if aLen > bLen then
        "GREATER"
    elif aLen < bLen then
        "LESS"
    elif aLen = 0 then
        "EQUAL"
    else
        let x = a |> Array.head |> int
        let y = b |> Array.head |> int
        if x > y then "GREATER"
        elif x < y then "LESS"
        else cmp (a |> Array.tail) (b |> Array.tail)

cmp a b |> printfn "%s"
