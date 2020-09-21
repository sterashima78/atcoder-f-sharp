let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| n; q |] ->
    let arr =
        n |> Array.zeroCreate |> Array.map (fun _ -> 0)

    [| 1 .. q |]
    |> Array.fold (fun x _ ->
        let [| l; r; t |] = readIntArray ()
        Array.fill x (l - 1) (r - l + 1) t
        x) arr
|> Array.map string
|> String.concat "\n"
|> printfn "%s"
