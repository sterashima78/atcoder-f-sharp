let toPermutation (list: 'a list): 'a list list =
    let difference xs ys =
        let ys = Set.ofList ys
        xs |> List.filter (ys.Contains >> not)

    let rec permutation (rest: 'a list) (current: 'a list) (answers: 'a list list) =
        match rest with
        | [] -> current :: answers
        | rest -> List.foldBack (fun x state -> permutation (difference rest [ x ]) (x :: current) state) rest answers

    permutation list [] []

let readInt _ = stdin.ReadLine() |> int

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let distance (coords: int [] []) (route :: routes) =
    let dist [| x1; y1 |] [| x2; y2 |] =
        (x1 - x2)
        * (x1 - x2)
        + (y1 - y2) * (y1 - y2)
        |> float
        |> sqrt

    routes
    |> List.fold (fun (before, d) current ->
        (current,
         d
         + (dist coords.[before - 1] coords.[current - 1]))) (route, 0.0)

()
|> readInt
|> fun x ->
    let coords = [| 1 .. x |] |> Array.map readIntArray

    [ 1 .. x ]
    |> toPermutation
    |> List.map (fun (routes: int list) -> distance coords routes)
    |> List.averageBy snd
    |> printfn "%f"
