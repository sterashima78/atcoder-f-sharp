let readCharArray _ = stdin.ReadLine().ToCharArray()

()
|> readCharArray
|> fun x ->
    let s = x |> Array.findIndex ((=) 'A')
    let e = x |> Array.findIndexBack ((=) 'Z')
    e - s + 1 |> printfn "%d"
