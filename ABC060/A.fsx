stdin.ReadLine().Split(" ")
|> fun x ->
    let tail =
        x
        |> Array.take 2
        |> Array.map (fun x -> x.ToCharArray() |> Array.rev |> Array.head)

    let head =
        x
        |> Array.rev
        |> Array.take 2
        |> Array.rev
        |> Array.map (fun x -> x.ToCharArray() |> Array.head)

    Array.zip tail head
    |> Array.filter (fun (a, b) -> a = b)
    |> Array.length
    |> fun x -> if x = 2 then "YES" else "NO"
    |> printfn "%s"
