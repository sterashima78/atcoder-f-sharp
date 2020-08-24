let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> (fun [| x; y |] -> [ 1 .. x ] |> List.map ((+) (y - 1)))
|> fun x ->
    let m = x |> List.minBy abs
    x |> List.filter ((<>) m) |> List.sum
|> printfn "%d"
