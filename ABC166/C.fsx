let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| _; m |] ->
    let heights =
        ()
        |> readIntArray
        |> Array.map (fun x -> (x, true))

    [| 1 .. m |]
    |> Array.fold (fun (h: (int * bool) []) _ ->
        let [| a; b |] = () |> readIntArray |> Array.map ((+) -1)

        let (aH, _) = h.[a]
        let (bH, _) = h.[b]
        if aH = bH then
            h.SetValue((aH, false), a)
            h.SetValue((bH, false), b)
        elif aH > bH then
            h.SetValue((bH, false), b)
        else
            h.SetValue((aH, false), a)
        h) heights
    |> Array.filter snd
    |> Array.length
|> printfn "%d"
