let readCharArray () = stdin.ReadLine().ToCharArray()
let readInt () = stdin.ReadLine() |> int

readCharArray ()
|> fun x ->
    [ for a in x do
        for b in x -> (string a) + (string b) ]
|> List.sort
|> List.take (readInt ())
|> List.rev
|> List.head
|> printfn "%s"
