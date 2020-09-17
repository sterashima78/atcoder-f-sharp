let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> fun [| k; s |] ->
    seq {
        for x in 0 .. k do
            if x <= s then
                for y in 0 .. k do
                    if (x + y) <= s && (k >= s - x - y) then yield 1
    }
    |> Seq.length
    |> printfn "%d"
