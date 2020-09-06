let readCharArray () = stdin.ReadLine().ToCharArray()

()
|> readCharArray
|> Array.filter (fun x ->
    x
    <> 'a'
    && x <> 'i'
    && x <> 'u'
    && x <> 'e'
    && x <> 'o')
|> System.String
|> printfn "%s"
