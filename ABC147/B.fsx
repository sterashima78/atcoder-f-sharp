let readCharArray () = stdin.ReadLine().ToCharArray()

readCharArray ()
|> fun x -> x |> Array.rev |> Array.zip x
|> Array.filter (fun (a, b) -> a <> b)
|> Array.length
|> (/)
<| 2
|> printfn "%d"
