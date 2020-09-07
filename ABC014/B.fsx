let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| _; x |] ->
    let y = readIntArray ()
    System.Convert.ToString(x, 2).ToCharArray()
    |> Array.rev
    |> fun arr ->
        let len =
            (y |> Array.length) - (arr |> Array.length)

        if len = 0 then
            arr
        else
            Array.concat [ arr
                           Array.init len (fun _ -> '0') ]
        |> Array.zip y
|> Array.filter (fun (_, key) -> key = '1')
|> Array.sumBy fst
|> printfn "%A"
