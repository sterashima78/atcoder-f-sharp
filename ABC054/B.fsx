let readCharArray _ = stdin.ReadLine().ToCharArray()

let readPicture n =
    [| 1 .. n |]
    |> Array.map (fun _ -> () |> readCharArray |> Array.indexed)
    |> Array.indexed
    |> Array.collect (fun (r, arr) -> arr |> Array.map (fun (c, ch) -> ((r, c), ch)))
    |> Map.ofArray

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec solve n m (row, col) template query =
    let isMatch =
        query
        |> Map.forall (fun (a, b) v -> template |> Map.find (a + row, b + col) |> (=) v)

    if isMatch then "Yes"
    elif n > m + col then solve n m (row, col + 1) template query
    elif n > m + row then solve n m (row + 1, 0) template query
    else "No"



()
|> readIntArray
|> fun [| n; m |] ->
    let t = n |> readPicture
    let q = m |> readPicture
    solve n m (0, 0) t q
|> printfn "%s"
