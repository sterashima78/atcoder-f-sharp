let readInt _ = stdin.ReadLine() |> int
let readCharArray _ = stdin.ReadLine().ToCharArray()

let rec solve ch =
    let h = ch |> Array.head
    let l = ch |> Array.last
    let len = ch |> Array.length
    if len = 1 then ch.[0] = 'b'
    elif len % 3 = 0 && h = 'a' && l = 'c' then solve ch.[1..(len - 2)]
    elif len % 3 = 1 && h = 'b' && l = 'b' then solve ch.[1..(len - 2)]
    elif len % 3 = 2 && h = 'c' && l = 'a' then solve ch.[1..(len - 2)]
    else false

()
|> readInt
|> fun x ->
    if x % 2 = 0 then -1
    elif solve (readCharArray ()) then x / 2
    else -1
|> printfn "%d"
