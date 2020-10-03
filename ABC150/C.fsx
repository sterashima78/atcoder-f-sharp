let readInt _ = stdin.ReadLine() |> int

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let toPermutation (list: 'a list): 'a list list =
    let difference xs ys =
        let ys = Set.ofList ys
        xs |> List.filter (ys.Contains >> not)

    let rec permutation (rest: 'a list) (current: 'a list) (answers: 'a list list) =
        match rest with
        | [] -> current :: answers
        | rest -> List.fold (fun state x -> permutation (difference rest [ x ]) (x :: current) state) answers rest

    permutation list [] []

()
|> readInt
|> fun x ->
    [ 1 .. x ]
    |> toPermutation
    |> List.map (fun x ->
        x
        |> List.map (string >> char)
        |> List.toArray
        |> System.String)
    |> List.sort
    |> fun a ->
        let str1 =
            ()
            |> readIntArray
            |> Array.map (string >> char)
            |> System.String

        let str2 =
            ()
            |> readIntArray
            |> Array.map (string >> char)
            |> System.String

        let n1 = a |> List.findIndex ((=) str1)
        let n2 = a |> List.findIndex ((=) str2)
        n1 - n2 |> abs
|> printfn "%d"
