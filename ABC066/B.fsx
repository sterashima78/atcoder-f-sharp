let readCharArray _ = stdin.ReadLine().ToCharArray()

let rec solve str =
    let len = str |> Array.length
    if len % 2 = 0
       && str.[0..(len / 2 - 1)] = str.[(len / 2)..(len - 1)] then
        len
    else
        str |> Array.tail |> solve

()
|> readCharArray
|> Array.rev
|> Array.tail
|> solve
|> printfn "%d"
