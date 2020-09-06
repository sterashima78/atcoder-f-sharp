let readInt () = stdin.ReadLine() |> int
let choice ok ng bool = if bool then ok else ng

()
|> readInt
|> fun x -> [ 1 .. x ] |> List.map (fun _ -> stdin.ReadLine())
|> fun list ->
    let isUniq =
        list
        |> List.groupBy id
        |> List.length
        |> (=)
        <| (list |> List.length)

    let isShiritori =
        list
        |> List.rev
        |> List.tail
        |> List.rev
        |> List.zip
        <| (list |> List.tail)
        |> List.filter (fun (x, y) -> x.[x.Length - 1] = y.[0])
        |> List.length
        |> (=)
        <| (list |> List.length |> (-) <| 1)

    isUniq && isShiritori
|> choice "Yes" "No"
|> printfn "%s"
