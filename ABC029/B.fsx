let readCharArray _ = stdin.ReadLine().ToCharArray()

[ 1 .. 12 ]
|> List.map (fun _ ->
    ()
    |> readCharArray
    |> Array.tryFindIndex ((=) 'r'))
|> List.filter (fun x ->
    match x with
    | None -> false
    | Some _ -> true)
|> List.length
|> printfn "%d"
