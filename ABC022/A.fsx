let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let readInt () = stdin.ReadLine() |> int

let [| n; a; b |] = readIntArray ()

[ 1 .. n ]
|> List.map (fun _ -> readInt ())
|> List.mapFold (fun x y -> (x, x + y)) 0
|> fun (x, y) ->
    x
    |> List.tail
    |> fun x -> y :: x
    |> List.filter (fun x -> a <= x && x <= b)
    |> List.length
    |> printfn "%A"
