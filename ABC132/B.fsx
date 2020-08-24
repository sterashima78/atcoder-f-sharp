let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()

readIntArray ()
|> fun x ->
    let len = x |> Array.length |> (-) <| 2
    let a = x |> Array.take len
    let b = x |> Array.tail |> Array.take len

    let c =
        x |> Array.tail |> Array.tail |> Array.take len

    Array.zip3 a b c
|> Array.filter (fun (x, y, z) -> (x > y && y > z) || (z > y && y > x))
|> Array.length
|> printfn "%d"
