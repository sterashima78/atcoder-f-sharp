let readInt _ = stdin.ReadLine() |> int

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let choice ok ng bool = if bool then ok else ng

()
|> readInt
|> fun x -> Seq.init x id
|> Seq.map readIntArray
|> Seq.fold (fun (ans, (t, x, y)) [| t1; x1; y1 |] ->
    if not ans then
        (false, (-1, -1, -1))
    else
        let d = (abs (x1 - x)) + (abs (y1 - y))
        let dt = t1 - t
        if d > dt then (false, (-1, -1, -1))
        elif d = dt then (true, (t1, x1, y1))
        elif d % 2 = dt % 2 then (true, (t1, x1, y1))
        else (false, (-1, -1, -1))) (true, (0, 0, 0))
|> fst
|> choice "Yes" "No"
|> printfn "%s"
